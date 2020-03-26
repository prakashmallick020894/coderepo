using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMT_Asset__Mgt_Tool_.Models
{
    public class Rasset
    {
        public int id { get; set; }
        public string category { get; set; }
        public string company { get; set; }
        public string model { get; set; }

        //[DataType(DataType.Date)]
        public string processor { get; set; }
        public string ram { get; set; }
        public string hdd { get; set; }
        public string ssd { get; set; }
        public string type { get; set; }
        public int p_date { get; set; }
    }
}
