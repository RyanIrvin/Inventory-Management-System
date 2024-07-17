namespace IMS.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ? Price { get; set; }
        public int Categoryid { get; set; }
        public Category Category { get; set; }
    }
}
