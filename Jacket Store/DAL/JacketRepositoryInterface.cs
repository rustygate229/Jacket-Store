using Jacket_Store.Models;

namespace Jacket_Store.DAL
{
    public interface JacketRepositoryInterface : IDisposable
    {
        void IDisposable.Dispose() {}

        //CRUD Methods

        //Read Methods ------------------

        //Customer Table
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int id);

        //Order Table
        IEnumerable<Order> GetOrders();
        Order GetOrderById(int id);
        IEnumerable<Order> GetOrdersByCustomerId(int id);

        //Product Table
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        Product GetProuctByWarehouse(int warehouseId);
        IEnumerable<Product> GetAllProductsAtWarehouse(Warehouse warehouseId);

        //Address Table 
        IEnumerable<Address> GetAddresses();
        Address GetAddressByCustomerId(int customerId);
        Address GetAddressById(int id);
        Address GetAddressByWarehouseID(int warehouseId);
        IEnumerable<Address> GetAddressesByStreet(String street);

        //Warehouse Table
        IEnumerable<Warehouse> GetWarehouses();
        Warehouse GetWarehouseById(int id);


        //Create Methods ----------------------------
        void InsertCustomer();
        void InsertOrder(Order order);
        void InsertProduct(Product product);
        void InsertProductToWarehouse(int warehouseID, Product product);
        void InsertAddress(Address address);
        void InsertWarehouse(Warehouse warehouse);


        //Update Methods -----------------------------


        //Delete Methods -----------------------------

    }
}
