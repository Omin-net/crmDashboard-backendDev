using Crm.Application.Products.DTOs;
using Crm.Domain.Products;

namespace Crm.Application.Products
{
    public interface IProductService
    {

        Task<List<Product>> GetAllProductsWithProductDetail();

    }

}
