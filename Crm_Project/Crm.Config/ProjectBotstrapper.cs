using Crm.Application.Products;
using Crm.Domain.Products.Repository;
using Crm.Infrastructure.Persestent.Ef;
using Crm.Infrastructure.Persestent.Ef.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Crm.Config
{
    public class ProjectBotstrapper
    {
        public static void Init(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IProductRepositroy, ProductRepository>();
            services.AddTransient<IProductService, ProductService>();

            services.AddDbContext<CrmContext>(option =>
            {
                option.UseSqlServer(connectionString);
            });
        }
    }
}
