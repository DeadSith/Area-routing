using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Sith.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public PasswordStore Store { get; set; }
    }
}