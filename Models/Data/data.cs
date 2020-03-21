using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AMT_Asset__Mgt_Tool_.Models.Data;

namespace AMT_Asset__Mgt_Tool_.Models.Data
{
    public class MVC_AMT_data : DbContext
    {
        public MVC_AMT_data (DbContextOptions<MVC_AMT_data> options)
            :base(options)
        {

        }
        public DbSet<AMT> AMT { get; set; }
    }
}
