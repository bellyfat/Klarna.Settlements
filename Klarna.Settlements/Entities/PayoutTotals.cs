using Newtonsoft.Json;

namespace Klarna.Settlements.Entities
{
    public class PayoutTotals
    {
        [JsonProperty(PropertyName = "commission_amount")]
        public int CommissionAmount { get; set; }
        [JsonProperty(PropertyName = "repay_amount")]
        public int RepayAmount { get; set; }
        [JsonProperty(PropertyName = "sale_amount")]
        public int SaleAmount { get; set; }
        [JsonProperty(PropertyName = "holdback_amount")]
        public int HoldbackAmount { get; set; }
        [JsonProperty(PropertyName = "tax_amount")]
        public int TaxAmount { get; set; }
        [JsonProperty(PropertyName = "settlement_amount")]
        public int SettlementAmount { get; set; }
        [JsonProperty(PropertyName = "fee_correction_amount")]
        public int FeeCorrectionAmount { get; set; }
        [JsonProperty(PropertyName = "reversal_amount")]
        public int ReversalAmount { get; set; }
        [JsonProperty(PropertyName = "release_amount")]
        public int ReleaseAmount { get; set; }
        [JsonProperty(PropertyName = "return_amount")]
        public int ReturnAmount { get; set; }
        [JsonProperty(PropertyName = "fee_amount")]
        public int FeeAmount { get; set; }
    }
}
