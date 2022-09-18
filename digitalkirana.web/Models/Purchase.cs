using System.ComponentModel.DataAnnotations;

namespace digitalkirana.web.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        [Required]
        public Decimal GrandTotal { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public Decimal Tax { get; set; }

        public Decimal Discount { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}