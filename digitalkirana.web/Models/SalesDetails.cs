using System.ComponentModel.DataAnnotations;

namespace digitalkirana.web.Models
{
    public class SalesDetails
    {
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        [Required]
        public Decimal Rate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public Decimal Total { get; set; }

        [Required]
        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }

        [Required]
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        [Required]
        public int SalesId { get; set; }
        public Sales? Sales { get; set; }
    }
}