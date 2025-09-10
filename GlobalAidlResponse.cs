// ÎÄ¼þ£ºGlobalAidlResponse.cs
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Wizarpos.Payment.Aidl
{
	[Serializable]
	public class GlobalAidlResponse
	{
		public string TransType { get; set; }
		public string TransScheme { get; set; }
		public string CallerName { get; set; }
		public string TransIndexCode { get; set; }
		public bool TransResult { get; set; }
		public string RespCode { get; set; }
		public string RespDesc { get; set; }
		public string ApprovalCode { get; set; }
		public string CardNum { get; set; }
		public int EntryMode { get; set; }
		public string ExpiryDate { get; set; }
		public string CardBrand { get; set; }
		public string TransAmount { get; set; }
		public string OtherAmount { get; set; }
		public string TipAmount { get; set; }
		public string Balance { get; set; }
		public string TaxAmount { get; set; }
		public string CurrencyCode { get; set; }
		public string DccOriCurrencyCode { get; set; }
		public string DccOriAmount { get; set; }
		public string DccFee { get; set; }
		public string DccExchangeRate { get; set; }
		public string DccMarkUp { get; set; }
		public string DccFooterText { get; set; }
		public string TransDate { get; set; }
		public string TransTime { get; set; }
		public string CountryCode { get; set; }
		public string MID { get; set; }
		public string TID { get; set; }
		public string MerchantName { get; set; }
		public string MerchantAddress { get; set; }
		public string TraceNum { get; set; }
		public string TransID { get; set; }
		public string InvoiceNum { get; set; }
		public string RRN { get; set; }
		public string AuthCode { get; set; }
		public string OriTransIndexCode { get; set; }
		public string OriInvoiceNum { get; set; }
		public string OriTransId { get; set; }
		public string OriRrn { get; set; }
		public string EmvAid { get; set; }
		public string EmvAppName { get; set; }
		public string EmvCryptogram { get; set; }
		public string EmvTVR { get; set; }
		public string AdditionalInfo { get; set; }
		public bool IsKeyLoaded { get; set; }
		public string CardUniqueId { get; set; }

		// === JSON ¸¨Öú ===
		public string ToJson(bool indented = false)
		{
			var opt = new JsonSerializerOptions
			{
				WriteIndented = indented,
				DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
				PropertyNamingPolicy = null
			};
			return JsonSerializer.Serialize(this, opt);
		}

		public static GlobalAidlResponse FromJson(string json)
		{
			var opt = new JsonSerializerOptions
			{
				PropertyNameCaseInsensitive = false,
				PropertyNamingPolicy = null
			};
			return JsonSerializer.Deserialize<GlobalAidlResponse>(json, opt);
		}

		public static string CreateErrorResponse(string message)
		{
			var r = new GlobalAidlResponse
			{
				TransResult = false,
				RespCode = "FF",
				RespDesc = message
			};
			return r.ToJson(false);
		}

		public override string ToString() => ToJson(false);
	}
}
