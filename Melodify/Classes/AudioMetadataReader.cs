using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using Melodify.Classes.Extensions;


namespace Melodify.Classes
{
    public static class AudioMetadataReader
    {
        public static AudioMetadata ReadMetadata(string filePath)
        {
            AudioMetadata metadata = null;

            using (var fileStream = File.OpenRead(filePath))
            using (var reader = new BinaryReader(fileStream))
            {
                string fileExtension = Path.GetExtension(filePath);
                if (StringComparer.OrdinalIgnoreCase.Equals(fileExtension, ".mp3"))
                {
                    // Check for ID3v2 tags at the beginning of the file
                    byte[] headerData = reader.ReadBytes(3);
                    if (Encoding.ASCII.GetString(headerData) == "ID3")
                    {
                        // Implement ID3v2 metadata reading here
                        metadata = ReadID3v2Metadata(reader);
                    }
                    else
                    {
                        // Check for ID3v1 tags at the end of the file
                        fileStream.Seek(-128, SeekOrigin.End);
                        byte[] id3v1Data = reader.ReadBytes(128);
                        if (Encoding.ASCII.GetString(id3v1Data, 0, 3) == "TAG")
                        {
                            metadata = ReadID3v1Metadata(id3v1Data);
                        }
                    }
                }
                else if (StringComparer.OrdinalIgnoreCase.Equals(fileExtension, ".flac"))
                {
                    // Parse Vorbis Comment metadata
                    metadata = ReadFlacMetadata(reader);
                }
                else
                {
                    throw new NotSupportedException("File format not supported");
                }
            }

            return metadata;
        }


        private static AudioMetadata ReadID3v1Metadata(byte[] data)
        {
            var encoding = CodePagesEncodingProvider.Instance.GetEncoding(1252);
            var metadata = new AudioMetadata();

            metadata.Title = encoding.GetString(data, 3, 30).TrimEnd('\0');
            metadata.Artists = new[] { encoding.GetString(data, 33, 30).TrimEnd('\0') };
            metadata.Album = encoding.GetString(data, 63, 30).TrimEnd('\0');
            metadata.Year = encoding.GetString(data, 93, 4).TrimEnd('\0');
            metadata.Track = data[126].ToString();

            return metadata;
        }

        private static AudioMetadata ReadID3v2Metadata(BinaryReader reader)
        {
            var metadata = new AudioMetadata();

            // Read ID3v2 header
            int version = reader.ReadByte();
            int revision = reader.ReadByte();
            byte flags = reader.ReadByte();
            int tagSize = ReadSynchSafeInt32(reader);

            long startPosition = reader.BaseStream.Position;

            while (reader.BaseStream.Position < startPosition + tagSize)
            {
                string frameId = Encoding.ASCII.GetString(reader.ReadBytes(4));

                if (frameId.Trim('\0').Length == 0)
                    break;

                int frameSize = ReadSynchSafeInt32(reader);
                reader.ReadByte(); // Skip flags
                reader.ReadByte(); // Skip flags

                byte[] frameData = reader.ReadBytes(frameSize);

                if (frameId == "TIT2")
                    metadata.Title = ReadTextFrame(frameData);
                else if (frameId == "TALB")
                    metadata.Album = ReadTextFrame(frameData);
                else if (frameId == "TPE1")
                    metadata.Artists = new[] { ReadTextFrame(frameData) };
                else if (frameId == "TYER" || frameId == "TDRC")
                    metadata.Year = ReadTextFrame(frameData);
                else if (frameId == "TRCK")
                    metadata.Track = ReadTextFrame(frameData);
                // Add more cases for other tags as needed
            }

            return metadata;
        }

        public static int ReadSynchSafeInt32(BinaryReader reader)
        {
            byte[] data = reader.ReadBytes(4);
            return (data[0] << 21) | (data[1] << 14) | (data[2] << 7) | data[3];
        }

        private static string ReadTextFrame(byte[] data)
        {
            if (data.Length < 1)
                return string.Empty;

            Encoding encoding;
            switch (data[0])
            {
                case 0: // ISO-8859-1
                    try
                    {
                        encoding = CodePagesEncodingProvider.Instance.GetEncoding("ISO-8859-1");
                    }
                    catch
                    {
                        return string.Empty;
                    }
                    break;
                case 1: // UTF-16 with BOM
                    encoding = Encoding.Unicode;
                    break;
                case 2: // UTF-16BE without BOM
                    encoding = Encoding.BigEndianUnicode;
                    break;
                case 3: // UTF-8
                    encoding = Encoding.UTF8;
                    break;
                default:
                    return string.Empty;
            }

            return encoding.GetString(data, 1, data.Length - 1).TrimEnd('\0');
        }

        private static AudioMetadata ReadFlacMetadata(BinaryReader reader)
        {
            var metadata = new AudioMetadata();

            // Read FLAC container header
            byte[] signature = reader.ReadBytes(4);
            if (Encoding.ASCII.GetString(signature) != "fLaC")
                throw new InvalidDataException("Invalid FLAC file signature.");

            // Read FLAC metadata blocks
            bool lastBlock = false;
            while (!lastBlock)
            {
                byte blockHeader = reader.ReadByte();
                lastBlock = (blockHeader & 0x80) != 0;
                int blockType = blockHeader & 0x7F;
                int blockSize = ReadInt24(reader);

                if (blockType == 4) // Vorbis comment block
                {
                    try
                    {
                        metadata = ReadVorbisComments(reader);
                        if (!lastBlock)
                            reader.BaseStream.Seek(blockSize - (reader.BaseStream.Position % blockSize), SeekOrigin.Current);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error reading Vorbis comments: {ex.Message}");
                    }
                }
                else
                {
                    reader.BaseStream.Seek(blockSize, SeekOrigin.Current);
                }
            }

            return metadata;
        }


        public static int ReadInt24(BinaryReader reader)
        {
            byte[] data = reader.ReadBytes(3);
            return (data[0] << 16) | (data[1] << 8) | data[2];
        }

        public static AudioMetadata ReadVorbisComments(BinaryReader reader)
        {
            var metadata = new AudioMetadata();

            // Read Vorbis comment header
            int vendorLength = reader.ReadInt32();
            if (vendorLength < 0 || vendorLength > reader.BaseStream.Length)
                throw new InvalidDataException("Invalid vendor string length.");

            reader.BaseStream.Seek(vendorLength, SeekOrigin.Current); // Skip vendor string

            int commentCount = reader.ReadInt32();
            if (commentCount < 0)
                throw new InvalidDataException("Invalid comment count.");

            for (int i = 0; i < commentCount; i++)
            {
                int commentLength = reader.ReadInt32();
                if (commentLength < 0 || commentLength > reader.BaseStream.Length)
                    throw new InvalidDataException("Invalid comment length.");

                string comment = Encoding.UTF8.GetString(reader.ReadBytes(commentLength));

                int separatorIndex = comment.IndexOf('=');
                if (separatorIndex >= 0)
                {
                    string key = comment.Substring(0, separatorIndex).ToUpperInvariant();
                    string value = comment.Substring(separatorIndex + 1);

                    if (key == "TITLE")
                        metadata.Title = value;
                    else if (key == "ALBUM")
                        metadata.Album = value;
                    else if (key == "ARTIST")
                        metadata.Artists = new[] { value };
                    else if (key == "DATE")
                        metadata.Year = value;
                    else if (key == "TRACKNUMBER")
                        metadata.Track = value;
                    // Add more cases for other tags as needed
                }
            }

            return metadata;
        }

    }
}