using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesSystemMVC.Models;

namespace SalesSystemMVC.Data
{
    public class SalesSystemMVCContext : DbContext
    {
        public SalesSystemMVCContext (DbContextOptions<SalesSystemMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesSystemMVC.Models.Department> Department { get; set; }
    }
}
