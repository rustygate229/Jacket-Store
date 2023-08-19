using System.ComponentModel.DataAnnotations;

namespace Jacket_Store.Models
{
    public class WarehouseProduct
    {
        [Key] public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }
    }
}
