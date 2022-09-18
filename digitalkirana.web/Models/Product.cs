using System.ComponentModel.DataAnnotations;

namespace digitalkirana.web.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? ProductName { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public string? Description { get; set; }

        public Decimal Rate { get; set; }

        public int Quantity { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public DateTime AddedDate { get; set; }
    }
}