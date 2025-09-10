// NormalSerialProtocol.cs
using System;

namespace SerialProto
{
    public static class NormalSerialProtocol
    {

        public static NormalSerialPortData PackData(byte[] content, int seq, byte ctrlCode)
        {
            var p = new NormalSerialPortData();
            p.Ctrl[0] = ctrlCode;
            p.Ctrl[1] = 0x00; 
            p.Ctrl[2] = (byte)((seq >> 8) & 0xFF);
            p.Ctrl[3] = (byte)(seq & 0xFF);
            p.Content = content ?? Array.Empty<byte>();
            return p;
        }
    }
}
