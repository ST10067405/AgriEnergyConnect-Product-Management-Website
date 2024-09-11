using AgriEnergyConnect.Data;

namespace AgriEnergyConnect.Models
{
    public class FarmerFilterViewModel
    {
        public string FarmerName { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string ProductType { get; set; }
        public IEnumerable<ApplicationUser> Farmers { get; set; }
    }

}
