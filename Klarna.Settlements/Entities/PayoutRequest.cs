using Newtonsoft.Json;

namespace Klarna.Settlements.Entities
{
    public class PayoutRequest
    {
        [JsonProperty(PropertyName = "start_date")]
        public string StartDate { get; set; }
        [JsonProperty(PropertyName = "end_date")]
        public string EndDate { get; set; }
        [JsonProperty(PropertyName = "currency_code")]
        public string CurrencyCode { get; set; }
        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }
        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }
    }
}
