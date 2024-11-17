using Crm.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace Crm.Infrastructure.Persestent.Ef
{
    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
