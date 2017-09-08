
using Newtonsoft.Json;

namespace Klarna.Settlements.Entities
{
   public class TransactionRequest
    {
        [JsonProperty(PropertyName = "payment_reference")]
        public string PaymentReference { get; set; }
        [JsonProperty(PropertyName = "order_id")]
        public string OrderId { get; set; }
        [JsonProperty(PropertyName = "size")]
        public int Size { get; set; }
        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }
    }
}
