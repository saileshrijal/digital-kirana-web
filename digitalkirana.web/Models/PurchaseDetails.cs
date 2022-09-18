using System.ComponentModel.DataAnnotations;

namespace digitalkirana.web.Models
{
    public class PurchaseDetails
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public Decimal Rate { get; set; }

        public int Quantity { get; set; }

        public Decimal Total { get; set; }

        public int SupplierId { get; set; }
        public Supplier? Supplier { get; set; }

        public DateTime AddedDate { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public int PurchaseId { get; set; }
        public Purchase? Purchase { get; set; }
    }
}