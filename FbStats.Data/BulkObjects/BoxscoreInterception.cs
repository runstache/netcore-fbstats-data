using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class BoxscoreInterception
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("interception")]
        public string Interceptions { get; set; }

        [JsonProperty("yards")]
        public string Yards { get; set; }

        [JsonProperty("td")]
        public string Touchdowns { get; set; }
    }
}
