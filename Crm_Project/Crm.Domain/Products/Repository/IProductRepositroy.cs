namespace Crm.Domain.Products.Repository
{
    public interface IProductRepositroy
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        bool DeleteProductById(Guid product);
        List<Product> GetAllProducts();
        Product GetProductById(Guid productId);
       
    }
}
