using AgriEnergyConnect.Data;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriEnergyConnect.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public DateTime ProductionDate { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser applicationUser { get; set; }
    }
}
