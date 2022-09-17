using System.ComponentModel.DataAnnotations;

namespace digitalkirana.web.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required, Display(Name = "Category Name")]
        public string? CategoryName { get; set; }

        public string? Description { get; set; }

        [Required]
        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        [Required, Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }
    }
}