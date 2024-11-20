using Crm.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace Crm.Infrastructure.Persestent.Ef
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductDetails)
                .WithOne(e => e.Product);

            // Seeding Product Data
            List<Product> ProductsList = new List<Product>()
        {
            new Product
            {
                ProductId=Guid.Parse("B8F16428-73C5-4C27-B087-50772880C50A"),
                ProductName="کفش جی اس",
                Color="سبز",
                Price=325000,
                CreationData=DateTime.Now,
                Description="کفش مردانه برند فلان خریداری شده از مهدی"
            },
            new Product
            {
                ProductId=Guid.Parse("98009939-06A2-4CC5-901A-D8FB8A09DF07"),
                ProductName="9 کفش جی اس",
                Color="قرمز",
                Price=100000,
                CreationData=DateTime.Now,
                Description="کفش مردانه برند فلان خریداری شده از اکبر"
            },
            new Product
            {
                ProductId=Guid.Parse("ABE4DD6C-E0D0-44F0-BC5B-F5962E37F5E5"),
                ProductName=" 15 کفش جی اس",
                Color="آبی",
                Price=250000,
                CreationData=DateTime.Now,
                Description="کفش مردانه برند فلان خریداری شده از محمد"
            }
        };
            modelBuilder.Entity<Product>().HasData(ProductsList);

            // Seeding Product Detail
            List<ProductDetail> ProductDetailsList = new List<ProductDetail>()
            {
                new ProductDetail
                {
                   ProductDetailId=Guid.Parse("563D1186-8689-4882-A814-BF9049782175"),
                   ProductCount=22,
                   ProductSize=39,
                   ProductId=Guid.Parse("B8F16428-73C5-4C27-B087-50772880C50A")
                },
                  new ProductDetail
                {
                   ProductDetailId=Guid.Parse("6DD2F615-F77D-4443-9B51-F4A3A7A4D349"),
                   ProductCount=33,
                   ProductSize=40,
                   ProductId=Guid.Parse("B8F16428-73C5-4C27-B087-50772880C50A")
                },
                    new ProductDetail
                {
                   ProductDetailId=Guid.Parse("25D0411A-44D8-4687-9041-1FCDA28250DE"),
                   ProductCount=66,
                   ProductSize=46,
                   ProductId=Guid.Parse("ABE4DD6C-E0D0-44F0-BC5B-F5962E37F5E5")
                }
            };
            modelBuilder.Entity<ProductDetail>().HasData(ProductDetailsList);
        }





    }
}
