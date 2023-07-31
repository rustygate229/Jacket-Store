namespace Jacket_Store.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
