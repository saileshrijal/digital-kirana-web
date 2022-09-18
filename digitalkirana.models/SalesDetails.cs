using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace digitalkirana.models
{
    public class SalesDetails
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public Decimal Rate { get; set; }

        public int Quantity { get; set; }

        public Decimal Total { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public DateTime AddedDate { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public int SalesId { get; set; }
        public Sales Sales { get; set; }
    }
}