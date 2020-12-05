using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace FbStats.Data.BulkObjects
{
    public class BulkGame
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("weekNumber")]
        public string WeekNumber { get; set; }

        [JsonProperty("homeTeam")]
        public BulkTeam HomeTeam { get; set; }

        [JsonProperty("visitorTeam")]
        public BulkTeam VisitorTeam { get; set; }

    }
}
