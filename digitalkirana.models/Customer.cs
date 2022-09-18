using System.ComponentModel.DataAnnotations;

namespace digitalkirana.models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, Display(Name = "Customer Name")]
        public string? CustomerName { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        [Required, Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }
    }
}