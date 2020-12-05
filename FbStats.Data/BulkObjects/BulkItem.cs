using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FbStats.Data.BulkObjects
{
    public class BulkItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("game")]
        public BulkGame Game { get; set; }

        [JsonProperty("boxscore")]
        public BulkBoxscore Boxscore { get; set; }

        [JsonProperty("matchup")]
        public BulkMatchup Matchup { get; set; }

        [JsonProperty("drives")]
        public List<Drive> Drives { get; set; }

        public BulkItem()
        {
            Boxscore = new BulkBoxscore();
            Drives = new List<Drive>();
            Game = new BulkGame();
            Matchup = new BulkMatchup();
        }
    }
}
