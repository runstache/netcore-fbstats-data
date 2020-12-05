using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class BoxscoreReceiving
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("receptions")]
        public string Receptions { get; set; }

        [JsonProperty("yards")]
        public string Yards { get; set; }

        [JsonProperty("average")]
        public string Average { get; set; }

        [JsonProperty("td")]
        public string Touchdowns { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }

        [JsonProperty("targets")]
        public string Targets { get; set; }
    }
}
