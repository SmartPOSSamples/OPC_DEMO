// ProtocolConsts.cs
namespace SerialProto
{
	public static class ProtocolConsts
	{
		public const byte STX = 0x02;
		public const byte ETX = 0x03;

		// ȱʡ�汾
		public const byte DEFAULT_VERSION = 0x01;

		
		public const byte CTRL_HANDSHAKE_REQ = 0xF1;
		public const byte CTRL_HANDSHAKE_RESP = 0xF2;

		
		public const byte CTRL_FROM_CASHIER = 0x01; 
		public const byte CTRL_FROM_POS = 0x02;

        public const byte CTRL_CANCEL_REQUEST = 0xC1;
        public const byte CTRL_CANNCEL_RESPONSE = 0xC2;

        public const byte CTRL_ACK_FROM_CASHIER = 0x03;
	}

	public static class HexUtil
	{
		public static string ToHex(byte[] data)
		{
			if (data == null) return "";
			var c = new char[data.Length * 2];
			int i = 0;
			foreach (var b in data)
			{
				c[i++] = GetHexChar(b >> 4);
				c[i++] = GetHexChar(b & 0xF);
			}
			return new string(c);
		}
		private static char GetHexChar(int v) => (char)(v < 10 ? v + '0' : v - 10 + 'A');
	}
}
