namespace AgriEnergyConnect.Models
{
    public class ProductFilterViewModel
    {
        public string ProductType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
