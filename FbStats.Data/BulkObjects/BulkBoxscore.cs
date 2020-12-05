using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class BulkBoxscore
    {
        [JsonProperty("passing")]
        public List<BoxscorePassing> Passing { get; set; }

        [JsonProperty("defense")]
        public List<BoxscoreDefense> Defense { get; set; }

        [JsonProperty("fumbles")]
        public List<BoxscoreFumbles> Fumbles { get; set; }

        [JsonProperty("interceptions")]
        public List<BoxscoreInterception> Interceptions { get; set; }

        [JsonProperty("kickReturns")]
        public List<BoxscoreReturn> KickReturns { get; set; }

        [JsonProperty("kicking")]
        public List<BoxscoreKicking> Kicking { get; set; }

        [JsonProperty("puntReturns")]
        public List<BoxscoreReturn> PuntReturns { get; set; }

        [JsonProperty("punting")]
        public List<BoxscorePunting> Punting { get; set; }

        [JsonProperty("receiving")]
        public List<BoxscoreReceiving> Receiving { get; set; }

        [JsonProperty("rushing")]
        public List<BoxscoreRushing> Rushing { get; set; }

        public BulkBoxscore()
        {
            Defense = new List<BoxscoreDefense>();
            Fumbles = new List<BoxscoreFumbles>();
            Interceptions = new List<BoxscoreInterception>();
            Kicking = new List<BoxscoreKicking>();
            KickReturns = new List<BoxscoreReturn>();
            Passing = new List<BoxscorePassing>();
            Punting = new List<BoxscorePunting>();
            PuntReturns = new List<BoxscoreReturn>();
            Receiving = new List<BoxscoreReceiving>();
            Rushing = new List<BoxscoreRushing>();
            
        }
    }
}
