using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class MatchupDefense
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("defensiveTouchdowns")]
        public string Touchdowns { get; set; }
    }
}
