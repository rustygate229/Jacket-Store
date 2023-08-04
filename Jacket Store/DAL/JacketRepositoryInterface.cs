using Jacket_Store.Models;

namespace Jacket_Store.DAL
{
    public interface JacketRepositoryInterface : IDisposable
    {
        void IDisposable.Dispose() {}

        //CRUD Methods

        //Read Methods ------------------

        //Customer Table
        ICollection<Customer> GetCustomers();
        Customer GetCustomerById(int customerId);

        //Order Table
        ICollection<Order> GetOrders();
        Order GetOrderById(int orderId);
        ICollection<Order> GetOrdersByCustomerId(int customerId);

        //Product Table
        ICollection<Product> GetProducts();
        Product GetProductById(int productId);
        Product GetProuctByWarehouse(int warehouseId);
        ICollection<Product> GetAllProductsAtWarehouse(Warehouse warehouseId);

        //Address Table 
        ICollection<Address> GetAddresses();
        Address GetAddressByCustomerId(int customerId);
        Address GetAddressById(int addressId);
        Address GetAddressByWarehouseID(int warehouseId);
        ICollection<Address> GetAddressesByStreet(String street);

        //Warehouse Table
        ICollection<Warehouse> GetWarehouses();
        Warehouse GetWarehouseById(int warehouseId);


        //Create Methods ----------------------------
        void InsertCustomer();
        void InsertOrder(Order order);
        void InsertProduct(Product product);
        void InsertProductToWarehouse(int warehouseID, Product product);
        void InsertAddress(Address address);
        void InsertWarehouse(Warehouse warehouse);


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
