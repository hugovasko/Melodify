using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodify.Classes.Extensions
{
    public static class BinaryWriterExtensions
    {
        public static void WriteInt24BE(this BinaryWriter writer, int value)
        {
            byte[] bytes = new byte[3];
            bytes[0] = (byte)((value >> 16) & 0xFF);
            bytes[1] = (byte)((value >> 8) & 0xFF);
            bytes[2] = (byte)(value & 0xFF);
            writer.Write(bytes);
        }
    }
}
