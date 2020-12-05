using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class MatchupPossessionTime
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("possessionTime")]
        public string PossessionTime { get; set; }
    }
}
