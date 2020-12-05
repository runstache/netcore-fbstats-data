using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class BoxscorePassing
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("attempts")]
        public string Attempts { get; set; }

        [JsonProperty("yards")]
        public string Yards { get; set; }

        [JsonProperty("avg")]
        public string Average { get; set; }

        [JsonProperty("td")]
        public string Touchdowns { get; set; }

        [JsonProperty("interception")]
        public string Interceptions { get; set; }

        [JsonProperty("sacks")]
        public string Sacks { get; set; }

        [JsonProperty("qbr")]
        public string Qbr { get; set; }
    }
}
