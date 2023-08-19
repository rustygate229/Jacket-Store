namespace Jacket_Store.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public required string Name { get; set; }
        public required string Make { get; set; }
        public required string Origin { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public ICollection<WarehouseProduct> WarehouseProducts { get; set; }

    }
}
