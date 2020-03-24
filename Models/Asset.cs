using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMT_Asset__Mgt_Tool_.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string Aname { get; set; }
        public string Model { get; set; }

        //[DataType(DataType.Date)]
        public string Type { get; set; }
        public string Status { get; set; }
        public string AssignedTo { get; set; }
        public string Location { get; set; }
        public string Cost { get; set; }
    }
}
