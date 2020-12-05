using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class BoxscoreDefense
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("total")]
        public string Tackles { get; set; }

        [JsonProperty("soloTackle")]
        public string SoloTackle { get; set; }

        [JsonProperty("sacks")]
        public string Sacks { get; set; }

        [JsonProperty("tackleForLoss")]
        public string TackleForLoss { get; set; }

        [JsonProperty("passDefended")]
        public string PassDefended { get; set; }

        [JsonProperty("qbHits")]
        public string QbHits { get; set; }

        [JsonProperty("td")]
        public string Touchdowns { get; set; }
    }
}
