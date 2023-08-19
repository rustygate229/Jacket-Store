using Jacket_Store.Models;
using Microsoft.AspNetCore.OutputCaching;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
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
                var temp_query = from wp in _context.WarehouseProducts
                                 where wp.ProductId == productId
                                 select wp;
                product.WarehouseProducts = temp_query.ToList();
            }

            return query;
        }

        public ICollection<WarehouseProduct> GetAllProductsAtWarehouse(int warehouseId)
        {
            var query = (from wp in _context.WarehouseProducts
                        where wp.WarehouseId == warehouseId
                        orderby wp.InventoryId
                        select wp).ToList();

            return query;
        }

        public ICollection<Address> GetAddresses()
        {
            // Uses LINQ query
            var query = (from addr in _context.Addresses
                            orderby addr.AddressId
                            select addr).ToList();

            return query;
        }

        public IQueryable<Address> GetAddressById(int addressId)
        {
            var query = from addr in _context.Addresses
                        where addr.AddressId == addressId
                        select addr;
            return query;
        }

        public ICollection<Address> GetAddressesByStreet(string street)
        {
            var query = (from addr in _context.Addresses
                        where addr.StreetName.Equals(street)
                        select addr).ToList();

            return query;
        }

        public IQueryable<Address> GetWarehouseAddress(int warehouseId)
        {

            var ware_query = _context.Warehouses.Where(w => w.WarehouseId == warehouseId).ToList();

            int addressId = ware_query.ElementAt(0).AddressId;

            var add_query = from addr in _context.Addresses
                            where addr.AddressId == addressId
                            select addr;

            return add_query;
        }

        public ICollection<Warehouse> GetWarehouses()
        {
            // Uses LINQ query
            var query = (from ware in _context.Warehouses
                            orderby ware.WarehouseId
                            select ware).ToList();

            return query;
        }

        public IQueryable<Warehouse> GetWarehouseById(int warehouseId)
        {
            var query = from ware in _context.Warehouses
                        where ware.WarehouseId == warehouseId
                        select ware;
            return query;
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
