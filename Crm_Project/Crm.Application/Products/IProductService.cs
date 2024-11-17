using Crm.Application.Products.DTOs;
using Crm.Domain.Products;

namespace Crm.Application.Products
{
    public interface IProductService
    {
        Product AddProduct(AddProductDto command);
        void EditProduct(EditProductDto command);
        List<ProductDto> GetProducts();
        Product GetProductById(Guid productId);
        bool DeleteProductById(Guid id);
    }
}
