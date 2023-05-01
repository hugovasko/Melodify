using System.IO;

namespace Melodify.Classes.Extensions
{
    public static class BinaryReaderExtensions
    {
        public static int ReadInt24BE(this BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(3);
            return (bytes[0] << 16) | (bytes[1] << 8) | bytes[2];
        }
    }
}