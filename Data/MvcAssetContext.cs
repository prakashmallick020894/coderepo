using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AMT_Asset__Mgt_Tool_.Models;

//Edited by Pallavi
namespace AMT_Asset__Mgt_Tool_.Data
{
    public class MvcAssetContext : DbContext
    {
        public MvcAssetContext(DbContextOptions<MvcAssetContext> options)
            : base(options)
        {
        }

        public DbSet<Asset> Asset { get; set; }
    }
}
