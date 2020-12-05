using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class BoxscorePunting
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("yards")]
        public string Yards { get; set; }

        [JsonProperty("average")]
        public string Average { get; set; }

        [JsonProperty("touchback")]
        public string Touchback { get; set; }

        [JsonProperty("inside20")]
        public string Inside20 { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }

    }
}
