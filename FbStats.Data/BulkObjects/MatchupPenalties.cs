using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class MatchupPenalties
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("penalties")]
        public string Penalties { get; set; }
    }
}
