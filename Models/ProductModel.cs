using System.ComponentModel;

namespace Activity3b.Models
{
    public class ProductModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Product Price")]
        public decimal Price { get; set; }
        [DisplayName("Product Description")]
        public string Description { get; set; }

    }
}
