// NormalSerialPortData.cs
using System;

namespace SerialProto
{
    public sealed class NormalSerialPortData
    {
        public byte Version { get; set; } = ProtocolConsts.DEFAULT_VERSION;
        public byte[] Ctrl { get; } = new byte[4]; 
        public byte[] Content { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// Éú³ÉÖ¡: STX | version | ctrl[4] | len(2,BE) | content | ETX | BCC
        /// BCC = XOR( from index=1 (version) to ETX )
        /// </summary>
        public byte[] GenerateBytes()
        {
            int n = Content?.Length ?? 0;
            var buf = new byte[1 + 1 + 4 + 2 + n + 1 + 1];

            int i = 0;
            buf[i++] = ProtocolConsts.STX;
            buf[i++] = Version;

            Array.Copy(Ctrl, 0, buf, i, 4); i += 4;

            buf[i++] = (byte)((n >> 8) & 0xFF); // LEN hi
            buf[i++] = (byte)(n & 0xFF);        // LEN lo

            if (n > 0) { Array.Copy(Content, 0, buf, i, n); i += n; }

            buf[i++] = ProtocolConsts.ETX;

            byte bcc = 0x00;
            for (int k = 1; k <= i - 1; k++)
                bcc ^= buf[k];

            buf[i++] = bcc;
            return buf;
        }
    }
}
