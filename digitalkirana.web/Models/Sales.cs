using System.ComponentModel.DataAnnotations;

namespace digitalkirana.web.Models
{
    public class Sales
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        [Required]
        public Decimal GrandTotal { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public Decimal Tax { get; set; }

        public Decimal Discount { get; set; }

        [Required]
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
    }
}