using System.ComponentModel.DataAnnotations;

namespace ProductCrudApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string? Category { get; set; }

       
        [Range(0.01, 999999.99, ErrorMessage = "Price must be greater than 0")]
        public decimal? Price { get; set; }

        public bool IsActive { get; set; }
    }
}
