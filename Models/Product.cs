using System.ComponentModel.DataAnnotations;

namespace ECommerceProductCatalog.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required, Range(1, 100000)]
        public decimal Price { get; set; }

        [Required, StringLength(50)]
        public string Category { get; set; }

        public string? ImagePath { get; set; } // Stores image filename
    }
}
