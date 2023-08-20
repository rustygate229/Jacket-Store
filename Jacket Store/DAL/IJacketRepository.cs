using Jacket_Store.Models;

namespace Jacket_Store.DAL
{
    public interface IJacketRepository : IDisposable
    {
        void IDisposable.Dispose() {}

        //CRUD Methods

        //Read Methods ------------------

        //Customer Table
        ICollection<Customer> GetCustomers();
        IQueryable<Customer> GetCustomerById(int customerId);

        //Order Table
        ICollection<Order> GetOrders();
        IQueryable<Order> GetOrderById(int orderId);

        //Product Table
        ICollection<Product> GetProducts();
        IQueryable<Product> GetProductById(int productId);
        ICollection<WarehouseProduct> GetAllProductsAtWarehouse(int warehouseId);

        //Address Table 
        ICollection<Address> GetAddresses();
        IQueryable<Address> GetAddressById(int addressId);
        ICollection<Address> GetAddressesByStreet(String street);
        IQueryable<Address> GetWarehouseAddress(int warehouseId);

        //Warehouse Table
        ICollection<Warehouse> GetWarehouses();
        IQueryable<Warehouse> GetWarehouseById(int warehouseId);


        //Create Methods ----------------------------
        Task InsertCustomer(Customer customer);
        Task InsertOrder(Order order);
        Task InsertProduct(Product product);
        Task InsertProductToWarehouse(int warehouseID, Product product);
        Task InsertAddress(Address address);
        Task InsertWarehouse(Warehouse warehouse);


        //Update Methods -----------------------------
        


        //Delete Methods -----------------------------

        //Order Table
        void DeleteOrdersByCustomer(int customerId);
        void DeleteAllOrders();
        void DeleteOrderById(int orderId);

        // Product Table
        void DeleteAllProducts();
        void DeleteProductByID(int productId);
        void DeleteProductInWarehouse(int productId, int warehouseId);

        // Warehouse Table
        void DeleteWarehouseById(int warehouseid);
        void DeleteProductsInWarehouse(int warehouseId);

    }
}
