using System;
using Newtonsoft.Json;

namespace Klarna.Settlements.Entities
{
    public class Transaction
    {

        [JsonProperty(PropertyName = "amount")]
        public int Amount;
        [JsonProperty(PropertyName = "capture_id")]
        public string CaptureId;
        [JsonProperty(PropertyName = "merchant_reference1")]
        public string MerchantReference1;
        [JsonProperty(PropertyName = "merchant_reference2")]
        public string MerchantReference2;
        [JsonProperty(PropertyName = "sale_date")]
        public DateTime SaleDate;
        [JsonProperty(PropertyName = "capture_date")]
        public DateTime CaptureDate;
        [JsonProperty(PropertyName = "type")]
        public string Type;
        [JsonProperty(PropertyName = "payment_reference")]
        public string PaymentReference;
        [JsonProperty(PropertyName = "order_id")]
        public string OrderId;
        [JsonProperty(PropertyName = "short_order_id")]
        public string ShortOrderId;
        [JsonProperty(PropertyName = "currency_code")]
        public string CurrencyCode;
        [JsonProperty(PropertyName = "payout")]
        public Uri Payout;
    }
}
