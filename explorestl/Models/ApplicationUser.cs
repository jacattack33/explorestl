using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace explorestl.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int ApplicationUserId { get; set; }
        public string DisplayName { get; set; } = "";

        public string Bio { get; set; } = "";

        public string Emoji { get; set; } = "";

    }
}