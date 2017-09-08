using System;
using Newtonsoft.Json;

namespace Klarna.Settlements.Entities
{
    public class Payout
    {
        [JsonProperty(PropertyName = "totals")]
        public PayoutTotals Total;

        [JsonProperty(PropertyName = "payment_reference")]
        public string PaymentReference { get; set; }
        [JsonProperty(PropertyName = "payout_date")]
        public string PayoutDate { get; set; }
        [JsonProperty(PropertyName = "currency_code")]
        public string CurrencyCode { get; set; }
        [JsonProperty(PropertyName = "merchant_settlement_type")]
        public string MerchantSettlementType { get; set; }
        [JsonProperty(PropertyName = "merchant_id")]
        public string MerchantId { get; set; }
        [JsonProperty(PropertyName = "transactions")]
        public Uri Transactions { get; set; }
    }
}
