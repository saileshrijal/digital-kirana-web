using System.ComponentModel.DataAnnotations;

namespace digitalkirana.models
{
    public class Sales
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public Decimal GrandTotal { get; set; }

        public DateTime Date { get; set; }

        public Decimal Tax { get; set; }

        public Decimal Discount { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

    }
}