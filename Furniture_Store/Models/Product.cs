namespace Furniture_Store.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public string ProductImage { get; set; }
        public string Dimensions { get; set; }
        public string ProductFeatures { get; set; }
        public virtual Category Category { get; set; }
    }
}
