namespace Jacket_Store.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductMake { get; set; }
        public string Origin { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public ICollection<Warehouse> Warehouses { get; set; }

    }
}
