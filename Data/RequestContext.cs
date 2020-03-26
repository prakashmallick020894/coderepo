using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AMT_Asset__Mgt_Tool_.Models;

namespace AMT_Asset__Mgt_Tool_.Data
{
    public class RequestContext: DbContext
    {
    
        
            public RequestContext(DbContextOptions<RequestContext> options)
                : base(options)
            {
            }

            public DbSet<Rasset> Rasset { get; set; }
        }
    }

