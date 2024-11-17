using Crm.Application.Products.DTOs;
using Crm.Domain.Products;
using Crm.Domain.Products.Repository;
namespace Crm.Application.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductRepositroy _productRepositroy;
        public ProductService(IProductRepositroy productRepositroy)
        {
            _productRepositroy = productRepositroy;
        }

        public bool DeleteProductById(Guid id)
        {
            var boleanIsDeleted = _productRepositroy.DeleteProductById(id);
            return boleanIsDeleted;
        }

        //public void AddProduct(AddProductDto command)
        //{
        //    var product = new Product(command.ProductName, command.Price, command.Description, command.Size, command.Color, command.Count);
        //    _productRepositroy.AddProduct(product);
        //}

        public void EditProduct(EditProductDto command)
        {
            var product = _productRepositroy.GetProductById(command.ProductId);
            product.EditProduct(command.ProductName, command.Price, command.Description, command.Size, command.Color, command.Count);
            _productRepositroy.UpdateProduct(product);
        }

        public Product GetProductById(Guid productId)
        {
            var product = _productRepositroy.GetProductById(productId);
            return product;
        }

        public List<ProductDto> GetProducts()
        {
            return _productRepositroy.GetAllProducts().Select(product => new ProductDto()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Price = product.Price,
                Description = product.Description,
                Size = product.Size,
                Color = product.Color,
                Count = product.Count

            }).ToList();
        }

        Product IProductService.AddProduct(AddProductDto command)
        {
            var product = new Product(command.ProductName, command.Price, command.Description, command.Size, command.Color, command.Count);
            _productRepositroy.AddProduct(product);
            return product;
        }

    
    }
}
