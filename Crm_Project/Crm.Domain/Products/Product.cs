using Crm.Domain.Products.Exceptions;
using System.ComponentModel.DataAnnotations;
namespace Crm.Domain.Products
{
    public class Product
    {
        private Product()
        {

        }
        public Product(string productName, int price, string description, int size, string color, int count)
        {

            Guard(productName, color, price, count, size);

            ProductId = Guid.NewGuid();
            ProductName = productName;
            CreationData = DateTime.Now;
            Price = price;
            Description = description;
            Size = size;
            Color = color;
            Count = count;
        }
        [Key]
        public Guid ProductId { get; private set; }

        [Required(ErrorMessage = "Enter the product name")]
        [StringLength(int.MaxValue, MinimumLength = 3, ErrorMessage = "Product name must have at least 3 characters")]
        public string ProductName { get; private set; }

        [RegularExpression(@"^$|^([1۱][۰-۹ 0-9]{3}[/\/]([0 ۰][۱-۶ 1-6])[/\/]([0 ۰][۱-۹ 1-9]|[۱۲12][۰-۹ 0-9]|[3۳][01۰۱])|[1۱][۰-۹ 0-9]{3}[/\/]([۰0][۷-۹ 7-9]|[1۱][۰۱۲012])[/\/]([۰0][1-9 ۱-۹]|[12۱۲][0-9 ۰-۹]|(30|۳۰)))$", ErrorMessage = "Invalid entered date")]
        public DateTime CreationData { get; private set; }

        [Required(ErrorMessage = "Enter the price of the product")]
        [Range(int.MinValue, 1)]
        public int Price { get; private set; }
        public string? Description { get; private set; }
        [Range(35, 49)]
        public int Size { get; private set; }
        public string Color { get; private set; }

        [Range(int.MinValue, 1)]
        public int Count { get; private set; }

        public void EditProduct(string productName, int price, string description, int size, string color, int count)
        {
            Guard(productName, color, price, count, size);
            ProductName = productName;
            Price = price;
            Description = description;
            Size = size;
            Color = color;
            Count = count;
        }

        private void Guard(string productName, string color, int price, int count, int size)
        {
            NullOrEmptyDomainDataException.CheckStirng(productName, nameof(productName));
            NullOrEmptyDomainDataException.CheckStirng(color, nameof(color));

            InvalidDomainDataException.CheckPrice(price);
            InvalidDomainDataException.CheckSize(size);
            InvalidDomainDataException.CheckCount(count);
        }

    }
}
