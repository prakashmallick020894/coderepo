using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AMT_Asset__Mgt_Tool_.Models;

namespace AMT_Asset__Mgt_Tool_.Data
{
    public class AMT_Asset__Mgt_Tool_Context : DbContext
    {
        public AMT_Asset__Mgt_Tool_Context (DbContextOptions<AMT_Asset__Mgt_Tool_Context> options)
            : base(options)
        {
        }

        public DbSet<AMT_Asset__Mgt_Tool_.Models.Movie> Movie { get; set; }
    }
}
