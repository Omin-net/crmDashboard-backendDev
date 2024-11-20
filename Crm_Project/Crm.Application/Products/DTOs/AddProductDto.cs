namespace Crm.Application.Products.DTOs
{
    public class AddProductDto
    { 

        public string ProductName { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public string Color { get; set; }
        public int Count { get; set; }
        public int Size { get; set; }
        
    }
    public class ProductDto()
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime CreationData { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public int Count { get; set; }
    }
    public class EditProductDto()
    {

        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime CreationData { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }
        public int Count { get; set; }
    }
}
