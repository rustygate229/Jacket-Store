﻿using Jacket_Store.Models;
using System.Data.Entity;

namespace Jacket_Store.DAL
{
    public class JacketRepository : JacketRepositoryInterface, IDisposable
    {
        private JacketContext _context;

        public JacketRepository(JacketContext context)
        {
            _context = context;
        }

        public ICollection<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Order> GetOrders()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Warehouse GetWarehouseById(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public void InsertCustomer()
        {
            throw new NotImplementedException();
        }

        public void InsertOrder(Order order)
        {
            throw new NotImplementedException();
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
