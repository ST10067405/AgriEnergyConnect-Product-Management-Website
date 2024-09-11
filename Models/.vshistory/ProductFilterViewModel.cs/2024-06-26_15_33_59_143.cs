using Microsoft.AspNetCore.Mvc.Rendering;

namespace AgriEnergyConnect.Models
{
    public class ProductFilterViewModel
    {
        public string ProductName { get; set; }
        public List<string> Categories { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
