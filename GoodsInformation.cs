
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Wizarpos.Payment.Aidl
{
    [Serializable]
    public class GoodsInformation
    {
       
        public string OrderNum { get; set; }
        public string OrderInfo { get; set; }
        public string OrderQuantity { get; set; }
        public string OrderUnitPrice { get; set; }

        public GoodsInformation() { }

        public GoodsInformation(string orderNum, string orderInfo, string orderQuantity, string orderUnitPrice)
        {
            OrderNum = orderNum;
            OrderInfo = orderInfo;
            OrderQuantity = orderQuantity;
            OrderUnitPrice = orderUnitPrice;
        }

        // ��ݣ�JSON ���л�/�����л��������ֶ�����Сд��
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

        public static GoodsInformation FromJson(string json)
        {
            var opt = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = false,
                PropertyNamingPolicy = null
            };
            return JsonSerializer.Deserialize<GoodsInformation>(json, opt);
        }

        public override string ToString() => ToJson(false);
    }
}
