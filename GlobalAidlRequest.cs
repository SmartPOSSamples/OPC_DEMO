
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Wizarpos.Payment.Aidl
{
    [Serializable]
    public class GlobalAidlRequest
    {
        public const string Purchase = "Purchase";
        public const string PreAuth = "PreAuth";
        public const string AuthCompletion = "AuthCompletion";
        public const string BalanceInquiry = "BalanceInquiry";
        public const string Reversal = "Reversal";
        public const string Refund = "Refund";
        public const string Settle = "Settle";
        public const string GetPosInfo = "GetPosInfo";
        public const string QueryTransaction = "QueryTransaction";
        public const string PrintLast = "PrintLast";
        public const string PrintTotal = "PrintTotal";
        public const string PrintDetail = "PrintDetail";
        public const string PrintParameter = "PrintParameter";
        public const string VerifyCardPan = "VerifyCardPan";

        public string TransType { get; set; }
        public string TransScheme { get; set; }
        public string CallerName { get; set; }
        public string TransIndexCode { get; set; }
        public string BusinessNum { get; set; }
        public string TerminalNum { get; set; }
        public string TransAmount { get; set; }
        public string OtherAmount { get; set; }
        public string TipAmount { get; set; }
        public string TaxAmount { get; set; }
        public string CurrencyCode { get; set; }
        public string ReqTransDate { get; set; }
        public string ReqTransTime { get; set; }
        public string OriTransIndexCode { get; set; }
        public string OriTraceNum { get; set; }
        public string OriInvoiceNum { get; set; }
        public string OriTransId { get; set; }
        public string OriRrn { get; set; }
        public string OriTransDate { get; set; }
        public string OriTransTime { get; set; }

        public bool EnableReceipt { get; set; }
        public string AppendingReceiptInfo { get; set; }
        public bool SkipConfirmProcedure { get; set; }
        public bool SkipUI { get; set; }

        private bool _enableCancelInPayment = true;
        public bool EnableCancelInPayment
        {
            get => _enableCancelInPayment;
            set => _enableCancelInPayment = value;
        }

        public string AdditionalInfo { get; set; }

        // liquid pay
        public List<GoodsInformation> goodsInfoList { get; set; }

        public string VoidReason { get; set; }
        public string TransactionId { get; set; }

        // Yolopago
        public string OriAuthCode { get; set; }

        public string ToJson(bool indented = false)
        {
            var opt = new JsonSerializerOptions
            {
                WriteIndented = indented,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            return JsonSerializer.Serialize(this, opt);
        }

        public static GlobalAidlRequest FromJson(string json)
        {
            var opt = new JsonSerializerOptions { PropertyNameCaseInsensitive = false };
            return JsonSerializer.Deserialize<GlobalAidlRequest>(json, opt);
        }

        public override string ToString() => ToJson(false);
    }
       
}
