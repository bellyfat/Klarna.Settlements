using System.Collections.Generic;
using Newtonsoft.Json;

namespace Klarna.Settlements.Entities
{
    public class PayoutResult
    {
        [JsonProperty(PropertyName = "payouts")]
        public List<Klarna.Settlements.Entities.Payout> Payouts;
        [JsonProperty(PropertyName = "pagination")]
        public Pagination Pagination;
    }
}
