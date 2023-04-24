using Newtonsoft.Json;
using System.Collections.Generic;

namespace APIRequest
{
    public class Root
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }


}
