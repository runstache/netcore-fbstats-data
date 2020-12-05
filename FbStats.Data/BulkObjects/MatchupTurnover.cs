using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class MatchupTurnover
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("turnovers")]
        public string Turnovers { get; set; }
    }
}
