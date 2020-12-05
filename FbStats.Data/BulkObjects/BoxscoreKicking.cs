using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class BoxscoreKicking
    {
        [JsonProperty("Team")]
        public string Team { get; set; }

        [JsonProperty("fieldGoal")]
        public string FieldGoal { get; set; }

        [JsonProperty("percentage")]
        public string Percentage { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }

        [JsonProperty("extraPoint")]
        public string ExtraPoints { get; set; }

        [JsonProperty("points")]
        public string Points { get; set; }
    }
}
