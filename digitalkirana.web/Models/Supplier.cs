using System.ComponentModel.DataAnnotations;

namespace digitalkirana.web.Models
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        public string? SupplierName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        [Required]
        public DateTime AddedDate { get; set; }
    }
}