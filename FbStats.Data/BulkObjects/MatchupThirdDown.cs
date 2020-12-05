using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class MatchupThirdDown
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("thirdDownEfficiency")]
        public string Efficiency { get; set; }
    }
}
