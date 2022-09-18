using System.ComponentModel.DataAnnotations;

namespace digitalkirana.web.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        public Decimal GrandTotal { get; set; }

        public DateTime Date { get; set; }

        public Decimal Tax { get; set; }

        public Decimal Discount { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}