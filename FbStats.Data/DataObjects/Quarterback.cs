using System;
using System.Collections.Generic;
using System.Text;

namespace FbStats.Data.DataObjects
{
    public class Quarterback
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
        public double Qbr { get; set; }

    }
}
