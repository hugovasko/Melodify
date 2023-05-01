using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Melodify.Classes.Extensions;

namespace Melodify.Classes
{
    public static class AudioMetadataWriter
    {
        public static void WriteMetadata(string filePath, AudioMetadata metadata)
        {
            string extension = Path.GetExtension(filePath).ToLowerInvariant();

            if (extension == ".mp3")
                WriteID3v2Metadata(filePath, metadata);
            else if (extension == ".flac")
                WriteFLACMetadata(filePath, metadata);
            else
                throw new NotSupportedException($"The file format '{extension}' is not supported.");
        }

        private static void WriteID3v2Metadata(string filePath, AudioMetadata metadata)
        {
            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            using (var reader = new BinaryReader(fileStream))
            using (var writer = new BinaryWriter(fileStream))
            {
                // Read the ID3v2 header
                byte[] headerData = reader.ReadBytes(3);
                if (Encoding.ASCII.GetString(headerData) == "ID3")
                {
                    // ID3v2 tag already exists, skip the header and remove existing frames
                    reader.BaseStream.Seek(7, SeekOrigin.Current);
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        string frameId = Encoding.ASCII.GetString(reader.ReadBytes(4));
                        if (frameId.Trim('\0').Length == 0)
                        {
                            break;
                        }

                        int frameSize = AudioMetadataReader.ReadSynchSafeInt32(reader);
                        reader.BaseStream.Seek(2, SeekOrigin.Current); // Skip flags
                        reader.BaseStream.Seek(frameSize, SeekOrigin.Current);
                    }
                }
                else
                {
                    // No ID3v2 tag found, write a new ID3v2 header
                    writer.Write(Encoding.ASCII.GetBytes("ID3"));
                    writer.Write((byte)3); // ID3v2.3.0
                    writer.Write((byte)0); // Revision
                    writer.Write((byte)0); // Flags
                    WriteSynchSafeInt32(writer, 0); // Tag size (placeholder, will update later)
                }

                // Save the position where the frames start
                long frameStartPosition = writer.BaseStream.Position;

                // Write frames
                WriteTextFrame(writer, "TIT2", metadata.Title);
                WriteTextFrame(writer, "TALB", metadata.Album);
                WriteTextFrame(writer, "TPE1", string.Join("/", metadata.Artists));
                WriteTextFrame(writer, "TYER", metadata.Year);
                WriteTextFrame(writer, "TRCK", metadata.Track);

                // Update the tag size in the ID3v2 header
                long tagSize = writer.BaseStream.Position - frameStartPosition;
                writer.BaseStream.Seek(6, SeekOrigin.Begin);
                WriteSynchSafeInt32(writer, (int)tagSize);
            }
        }

        private static void WriteSynchSafeInt32(BinaryWriter writer, int value)
        {
            writer.Write((byte)((value >> 21) & 0x7F));
            writer.Write((byte)((value >> 14) & 0x7F));
            writer.Write((byte)((value >> 7) & 0x7F));
            writer.Write((byte)(value & 0x7F));
        }

        private static void WriteTextFrame(BinaryWriter writer, string frameId, string text)
        {
            byte[] textData = Encoding.UTF8.GetBytes(text);
            writer.Write(Encoding.ASCII.GetBytes(frameId));
            WriteSynchSafeInt32(writer, textData.Length + 1); // Frame size
            writer.Write((byte)0); // Flags
            writer.Write((byte)0); // Flags
            writer.Write((byte)3); // Encoding: UTF-8
            writer.Write(textData);
        }


        private static void WriteFLACMetadata(string filePath, AudioMetadata metadata)
        {
            using (var fileStream = File.Open(filePath, FileMode.Open, FileAccess.ReadWrite))
            using (var reader = new BinaryReader(fileStream))
            using (var writer = new BinaryWriter(fileStream))
            {
                // Read FLAC container header
                byte[] signature = reader.ReadBytes(4);
                if (Encoding.ASCII.GetString(signature) != "fLaC")
                    throw new InvalidDataException("Invalid FLAC file signature.");

                bool lastBlock = false;
                long blockStartPosition = 0;
                while (!lastBlock)
                {
                    blockStartPosition = fileStream.Position;
                    byte blockHeader = reader.ReadByte();
                    lastBlock = (blockHeader & 0x80) != 0;
                    int blockType = blockHeader & 0x7F;
                    int blockSize = AudioMetadataReader.ReadInt24(reader);

                    if (blockType == 4) // Vorbis comment block
                    {
                        // Read existing Vorbis comments
                        AudioMetadata existingMetadata = AudioMetadataReader.ReadVorbisComments(reader);

                        // Merge the new metadata with the existing metadata
                        AudioMetadata mergedMetadata = MergeMetadata(existingMetadata, metadata);

                        // Write the updated Vorbis comments
                        fileStream.Position = blockStartPosition;
                        WriteVorbisComments(writer, mergedMetadata, blockSize);
                    }
                    else
                    {
                        fileStream.Seek(blockSize, SeekOrigin.Current);
                    }
                }
            }
        }

        private static AudioMetadata MergeMetadata(AudioMetadata existingMetadata, AudioMetadata newMetadata)
        {
            var mergedMetadata = new AudioMetadata
            {
                Title = newMetadata.Title ?? existingMetadata.Title,
                Album = newMetadata.Album ?? existingMetadata.Album,
                Artists = newMetadata.Artists.Length > 0 ? newMetadata.Artists : existingMetadata.Artists,
                Year = newMetadata.Year ?? existingMetadata.Year,
                Track = newMetadata.Track ?? existingMetadata.Track,
                // Add other properties as needed
            };

            return mergedMetadata;
        }

        private static void WriteVorbisComments(BinaryWriter writer, AudioMetadata metadata, int originalBlockSize)
        {
            MemoryStream commentStream = new MemoryStream();
            using (var commentWriter = new BinaryWriter(commentStream))
            {
                // Write vendor string
                string vendorString = "reference libFLAC 1.3.2 20170101";
                byte[] vendorBytes = Encoding.UTF8.GetBytes(vendorString);
                commentWriter.Write(vendorBytes.Length);
                commentWriter.Write(vendorBytes);

                // Write the number of comments
                int commentCount = 5; // Adjust this based on the number of properties you want to write
                commentWriter.Write(commentCount);

                // Write each comment
                WriteVorbisComment(commentWriter, "TITLE", metadata.Title);
                WriteVorbisComment(commentWriter, "ALBUM", metadata.Album);
                WriteVorbisComment(commentWriter, "ARTIST", string.Join(", ", metadata.Artists));
                WriteVorbisComment(commentWriter, "DATE", metadata.Year);
                WriteVorbisComment(commentWriter, "TRACKNUMBER", metadata.Track);
            }

            // Write the Vorbis comments to the FLAC file
            if (commentStream.Length <= originalBlockSize)
            {
                writer.Write(commentStream.ToArray());
                // Pad the remaining space in the block with zeroes
                for (int i = 0; i < originalBlockSize - commentStream.Length; i++)
                {
                    writer.Write((byte)0);
                }
            }
            else
            {
                // Handle the case where the new Vorbis comments are larger than the original block size
                // (e.g., by allocating a new block in the file or informing the user)
            }
        }


        private static void WriteVorbisComment(BinaryWriter writer, string key, string value)
        {
            string comment = key + "=" + value;
            byte[] commentData = Encoding.UTF8.GetBytes(comment);
            writer.Write(commentData.Length);
            writer.Write(commentData);
        }
    }
}