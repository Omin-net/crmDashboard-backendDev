using Crm.Domain.Products;
using Crm.Domain.Products.Repository;

namespace Crm.Infrastructure.Persestent.Ef.Repository
{
    public class ProductRepository : IProductRepositroy
    {
        private readonly CrmContext _context;
        public ProductRepository(CrmContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        //public void DeleteProduct(Product product)
        //{
        //    _context.Products.Remove(product);
        //}

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(Guid productId)
        {
            return _context.Products.FirstOrDefault(f => f.ProductId == productId);
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public bool DeleteProductById(Guid productId)
        {

            Product? matchedPrduct = _context.Products.FirstOrDefault(f => f.ProductId == productId);
            _context.Products.Remove(matchedPrduct);
            var count = _context.SaveChanges();
            return count > 0 ? true : false;
        }

      
    }
}
