namespace Crm.Domain.Products.Repository
{
    public interface IProductRepositroy
    {
        //void AddProduct(Product product);
        //void UpdateProduct(Product product);
        //bool DeleteProductById(Guid product);
        Task<List<Product>> GetAllProductsWithProductDetail();
        //Product GetProductById(Guid productId);

    }
}
