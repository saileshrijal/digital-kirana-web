using System.ComponentModel.DataAnnotations;

namespace digitalkirana.web.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, Display(Name = "Product Name")]
        public string? ProductName { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public string? Description { get; set; }

        [Required]
        public Decimal Rate { get; set; }

        public int Quantity { get; set; }

        [Required]
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        [Required, Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }
    }
}