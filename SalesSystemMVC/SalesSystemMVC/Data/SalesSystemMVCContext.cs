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

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords{ get; set; }
    }
}
