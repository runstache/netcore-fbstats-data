using System;
using System.Collections.Generic;
using System.Text;

namespace FbStats.Data.DataObjects
{
    public class Team
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int TotalGames { get; set; }
    }
}
