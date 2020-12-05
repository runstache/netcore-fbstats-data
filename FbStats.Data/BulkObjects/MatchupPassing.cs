using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class MatchupPassing
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("totalPassingYards")]
        public string TotalYards { get; set; }

        [JsonProperty("totalPassingAttempts")]
        public string Attempts { get; set; }

        [JsonProperty("yardsPerPass")]
        public string YardsPerPass { get; set; }

    }
}
