using System;
using System.Collections.Generic;
using System.Text;

namespace FbStats.Data.DataObjects
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int VisitorTeamId { get; set; }
        public int WeekNumber { get; set; }
        public int YearValue { get; set; }
    }
}
