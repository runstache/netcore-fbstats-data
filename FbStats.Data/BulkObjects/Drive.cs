using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class Drive
    {
        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("passes")]
        public string Passes { get; set; }

        [JsonProperty("runs")]
        public string Runs { get; set; }

        [JsonProperty("turnovers")]
        public string Turnovers { get; set; }
    }
}
