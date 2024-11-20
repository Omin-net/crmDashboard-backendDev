using Crm.Domain.Products.Exceptions;
using System.ComponentModel.DataAnnotations;
namespace Crm.Domain.Products
{
    public class Product
    {

        [Key]
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "Enter the product name")]
        [StringLength(int.MaxValue, MinimumLength = 3, ErrorMessage = "Product name must have at least 3 characters")]
        public string ProductName { get; set; }

        [RegularExpression(@"^$|^([1۱][۰-۹ 0-9]{3}[/\/]([0 ۰][۱-۶ 1-6])[/\/]([0 ۰][۱-۹ 1-9]|[۱۲12][۰-۹ 0-9]|[3۳][01۰۱])|[1۱][۰-۹ 0-9]{3}[/\/]([۰0][۷-۹ 7-9]|[1۱][۰۱۲012])[/\/]([۰0][1-9 ۱-۹]|[12۱۲][0-9 ۰-۹]|(30|۳۰)))$", ErrorMessage = "Invalid entered date")]
        public DateTime CreationData { get; set; }

        [Required(ErrorMessage = "Enter the price of the product")]
        [Range(int.MinValue, 1)]
        public int Price { get; set; }
        public string? Description { get; set; }

        public string Color { get; set; }


        //relationship one-to-many relation with productDetail
        public ICollection<ProductDetail> ProductDetails { get; set; } = new List<ProductDetail>();





    }
}
