using Crm.Application.Products;
using Crm.Domain.Products.Repository;
using Crm.Infrastructure.Persestent.Ef;
using Crm.Infrastructure.Persestent.Ef.Repository.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Crm.Config
{
    public class ProjectBotstrapper
    {
        public static void Init(IServiceCollection services, string connectionString)
        {
            services.AddScoped<IProductRepositroy, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddDbContext<ApplicationDbContext>(option =>
            {
                option.UseSqlServer(connectionString);
            });
        }
    }
}
