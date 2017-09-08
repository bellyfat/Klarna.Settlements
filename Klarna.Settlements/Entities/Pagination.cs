using System;
using Newtonsoft.Json;

namespace Klarna.Settlements.Entities
{
    public class Pagination
    {
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }
        [JsonProperty(PropertyName = "total")]
        public int Total { get; set; }
        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }
        [JsonProperty(PropertyName = "next")]
        public Uri Next { get; set; }
        [JsonProperty(PropertyName = "prev")]
        public Uri Prev { get; set; }
    }
}
