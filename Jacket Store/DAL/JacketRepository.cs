using Jacket_Store.Models;
using System.Data.Entity;
using System.Runtime.CompilerServices;

namespace Jacket_Store.DAL
{
    public class JacketRepository : IJacketRepository, IDisposable
    {
        private JacketContext _context;

        public JacketRepository(JacketContext context)
        {
            _context = context;
        }

        // Gets all customers in JSON format
        public ICollection<Customer> GetCustomers()
        {
            // Uses LINQ query
            using (var context = _context)
            {
                var query = (from cus in context.Customers
                 orderby cus.CustomerID
                 select cus).ToList();

                return query;
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Order> GetOrders()
        {
            // Uses LINQ query
            using (var context = _context)
            {
                var query = (from ord in context.Orders
                             orderby ord.OrderId
                             select ord).ToList();

                return query;
            }
        }

        public Order GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Order> GetOrdersByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetProducts()
        {
            // Uses LINQ query
            using (var context = _context)
            {
                var query = (from pro in context.Products
                             orderby pro.ProductID
                             select pro).ToList();

                return query;
            }
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProuctByWarehouse(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetAllProductsAtWarehouse(Warehouse warehouseId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Address> GetAddresses()
        {
            // Uses LINQ query
            using (var context = _context)
            {
                var query = (from addr in context.Addresses
                             orderby addr.AddressId
                             select addr).ToList();

                return query;
            }
        }

        public Address GetAddressByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public Address GetAddressById(int addressId)
        {
            throw new NotImplementedException();
        }

        public Address GetAddressByWarehouseID(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Address> GetAddressesByStreet(string street)
        {
            throw new NotImplementedException();
        }

        public ICollection<Warehouse> GetWarehouses()
        {
            Console.WriteLine("Getting Warehouses...");
            // Uses LINQ query
            using (var context = _context)
            {
                var query = (from ware in context.Warehouses
                             orderby ware.WarehouseId
                             select ware).ToList();

                return query;
            }
        }

        public Warehouse GetWarehouseById(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public void InsertCustomer(Customer customer)
        {
            using (var context = _context)
            {
                //Create a new customer and save it
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void InsertOrder(Order order)
        {
            using (var context = _context)
            {
                //Create a new customer and save it
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public void InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void InsertProductToWarehouse(int warehouseID, Product product)
        {
            throw new NotImplementedException();
        }

        public void InsertAddress(Address address)
        {
            throw new NotImplementedException();
        }

        public void InsertWarehouse(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrdersByCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllOrders()
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderById(int orderId)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllProducts()
        {
            throw new NotImplementedException();
        }

        public void DeleteProductByID(int productId)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductInWarehouse(int productId, int warehouseId)
        {
            throw new NotImplementedException();
        }

        public void DeleteWarehouseById(int warehouseid)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductsInWarehouse(int warehouseId)
        {
            throw new NotImplementedException();
        }

        // Dispose Method

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
