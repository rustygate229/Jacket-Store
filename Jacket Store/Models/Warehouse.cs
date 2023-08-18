namespace Jacket_Store.Models
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        public int AddressID { get; set; }
        public string Manager { get; set; }
        public string PhoneNum { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
