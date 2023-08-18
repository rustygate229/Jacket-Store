using Jacket_Store.Models;
using System.Data.Entity;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
            var query = (from cus in _context.Customers
                orderby cus.CustomerID
                select cus).ToList();

            return query;
        }

        public IQueryable<Customer> GetCustomerById(int customerId)
        {
            var query = (from cus in _context.Customers
                         where cus.CustomerID == customerId
                         select cus);
            return query;
        }

        public ICollection<Order> GetOrders()
        {
            // Uses LINQ query
            var query = (from ord in _context.Orders
                            orderby ord.OrderId
                            select ord).ToList();

            return query;
        }

        public IQueryable<Order> GetOrderById(int orderId)
        {
            var query = from ord in _context.Orders
                        where ord.OrderId == orderId
                        select ord;
            return query;
        }

        public ICollection<Order> GetOrdersByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetProducts()
        {
            // Uses LINQ query
            var query = (from pro in _context.Products
                            orderby pro.ProductID
                            select pro).ToList();

            return query;
        }

        public IQueryable<Product> GetProductById(int productId)
        {
            var query = from pro in _context.Products
                        where pro.ProductID == productId
                        select pro;

            foreach(Product product in query.ToList())
            {
                var temp_query = (_context.Products.Where(p => p.ProductID == productId).SelectMany(p => _context.Warehouses));
                product.Warehouses = temp_query.ToList();
            }

            return query;
        }

        public IQueryable<Product> GetProuctByWarehouse(int warehouseId)
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
            var query = (from addr in _context.Addresses
                            orderby addr.AddressId
                            select addr).ToList();

            return query;
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
            // Uses LINQ query
            var query = (from ware in _context.Warehouses
                            orderby ware.WarehouseId
                            select ware).ToList();

            return query;
        }

        public Warehouse GetWarehouseById(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public async Task InsertCustomer(Customer customer)
        {
            //Create a new customer and save it
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task InsertOrder(Order order)
        {
            //Create a new order and save it
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
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
