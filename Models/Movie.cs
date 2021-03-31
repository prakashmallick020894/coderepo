using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMT_Asset__Mgt_Tool_.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string Sdd { get; set; }
        public string Hdd { get; set; }
        public DateTime Purchasedate { get; set; }
        public string Type { get; set; }
    }
}
