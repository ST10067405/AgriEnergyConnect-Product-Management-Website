using Microsoft.AspNetCore.Identity;
using System.Diagnostics.CodeAnalysis;
namespace AgriEnergyConnect.Data
{
    public class ApplicationUser : IdentityUser
    {
        [AllowNull]
        public string FirstName { get; set; }
        [AllowNull]
        public string LastName { get; set; }
    }
}
