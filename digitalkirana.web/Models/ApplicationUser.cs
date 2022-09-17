using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace digitalkirana.web.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required, Display(Name = "First Name")]
        public string? LastName { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public string? Address { get; set; }
    }
}