using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class BoxscoreFumbles
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("fumble")]
        public string Fumbles { get; set; }

        [JsonProperty("lost")]
        public string FumbleLost { get; set; }

        [JsonProperty("recovered")]
        public string FumbleRecovered { get; set; }
        
    }
}
