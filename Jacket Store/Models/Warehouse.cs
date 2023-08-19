using System.ComponentModel.DataAnnotations;

namespace Jacket_Store.Models
{
    public class Warehouse
    {
        [Key] public int WarehouseId { get; set; }
        public int AddressId { get; set; }
        public string Manager { get; set; }
        public string PhoneNum { get; set; }
        public ICollection<WarehouseProduct> WarehouseProducts { get; set; }
    }
}
