using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class MatchupRushing
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("totalRushingYards")]
        public string TotalYards { get; set; }

        [JsonProperty("totalAttempts")]
        public string Attempts { get; set; }

        [JsonProperty("yardsPerRush")]
        public string YardPerRush { get; set; }
    }
}
