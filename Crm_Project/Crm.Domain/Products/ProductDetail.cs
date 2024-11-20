using Crm.Domain.Products.Exceptions;
using System.ComponentModel.DataAnnotations;

namespace Crm.Domain.Products
{
    public class ProductDetail
    {

        [Key]
        public Guid ProductDetailId { get;  set; }

        [Range(int.MinValue, 1)]
        public int ProductCount { get;  set; }

        [Range(35, 49)]
        public int ProductSize { get;  set; }


        // relation
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
