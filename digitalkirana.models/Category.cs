using System.ComponentModel.DataAnnotations;

namespace digitalkirana.models
{
    public class Category
    {
        public int Id { get; set; }

        public string? CategoryName { get; set; }

        public string? Description { get; set; }

        public string? ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }

        public DateTime AddedDate { get; set; }
    }
}