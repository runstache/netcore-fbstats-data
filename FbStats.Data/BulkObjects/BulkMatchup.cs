using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class BulkMatchup
    {
        [JsonProperty("defenseTouchdowns")]
        public List<MatchupDefense> Defense { get; set; }

        [JsonProperty("passingStats")]
        public List<MatchupPassing> Passing { get; set; }

        [JsonProperty("penalties")]
        public List<MatchupPenalties> Penalties { get; set; }

        [JsonProperty("possessionTime")]
        public List<MatchupPossessionTime> PossessionTime { get; set; }

        [JsonProperty("redzone")]
        public List<MatchupRedzone> Redzone { get; set; }

        [JsonProperty("rushing")]
        public List<MatchupRushing> Rushing { get; set; }

        [JsonProperty("thirdDown")]
        public List<MatchupThirdDown> ThirdDown { get; set; }

        [JsonProperty("totalPlays")]
        public List<MatchupTurnover> TotalPlays { get; set; }

        [JsonProperty("turnovers")]
        public List<MatchupTurnover> Turnovers { get; set; }

        public BulkMatchup()
        {
            Defense = new List<MatchupDefense>();
            Passing = new List<MatchupPassing>();
            Penalties = new List<MatchupPenalties>();
            PossessionTime = new List<MatchupPossessionTime>();
            Redzone = new List<MatchupRedzone>();
            Rushing = new List<MatchupRushing>();
            ThirdDown = new List<MatchupThirdDown>();
            TotalPlays = new List<MatchupTurnover>();
            Turnovers = new List<MatchupTurnover>();
            
        }
    }
}