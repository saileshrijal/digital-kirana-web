using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace digitalkirana.models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Gender { get; set; }

        public bool Active { get; set; }

        public string? Address { get; set; }
    }
}