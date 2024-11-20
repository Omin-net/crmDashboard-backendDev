using Crm.Domain.Products;
using Crm.Domain.Products.Repository;
using Microsoft.EntityFrameworkCore;

namespace Crm.Infrastructure.Persestent.Ef.Repository.Products
{
    public class ProductRepository : IProductRepositroy
    {

        private readonly ApplicationDbContext _context;

        // constructor
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsWithProductDetail()
        {
            List<Product> products = await _context.Products.Include(product => product.ProductDetails).ToListAsync();

            return products;
        }













        //    public void AddProduct(Product product)
        //    {
        //        _context.Products.Add(product);
        //        _context.SaveChanges();
        //    }

        //    //public void DeleteProduct(Product product)
        //    //{
        //    //    _context.Products.Remove(product);
        //    //}

        //    public List<Product> GetAllProducts()
        //    {
        //        return _context.Products.ToList();
        //    }

        //    public Product GetProductById(Guid productId)
        //    {
        //        return _context.Products.FirstOrDefault(f => f.ProductId == productId);
        //    }

        //    public void UpdateProduct(Product product)
        //    {
        //        _context.Products.Update(product);
        //        _context.SaveChanges();
        //    }

        //    public bool DeleteProductById(Guid productId)
        //    {

        //        Product? matchedPrduct = _context.Products.FirstOrDefault(f => f.ProductId == productId);
        //        _context.Products.Remove(matchedPrduct);
        //        var count = _context.SaveChanges();
        //        return count > 0 ? true : false;
        //    }

        //    public void AddProduct(Domain.Products.Product product)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void UpdateProduct(Domain.Products.Product product)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    List<Domain.Products.Product> IProductRepositroy.GetAllProducts()
        //    {
        //        throw new NotImplementedException();
        //    }

        //    Domain.Products.Product IProductRepositroy.GetProductById(Guid productId)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}