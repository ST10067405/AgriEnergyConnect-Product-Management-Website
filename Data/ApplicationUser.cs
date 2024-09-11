using Microsoft.AspNetCore.Identity;
using System.Diagnostics.CodeAnalysis;
namespace AgriEnergyConnect.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
