using System;
using Newtonsoft.Json;

namespace APIRequest
{
    public class Datum
    {
        [JsonProperty("open")]
        public double Open { get; set; }

        [JsonProperty("high")]
        public double High { get; set; }

        [JsonProperty("low")]
        public double Low { get; set; }

        [JsonProperty("close")]
        public double Close { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }

}
