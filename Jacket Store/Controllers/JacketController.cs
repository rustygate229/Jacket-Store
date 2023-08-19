using Jacket_Store.DAL;
using Jacket_Store.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity.Core.Mapping;
using System.Net;

namespace Jacket_Store.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JacketController : ControllerBase
    {

        // Dependency Injections
        private readonly ILogger<JacketController> _logger;
        private IJacketRepository _jacketRepository;

        public JacketController(ILogger<JacketController> logger, IJacketRepository jacketRepository)
        {
            _logger = logger;
            _jacketRepository = jacketRepository;
        }

        [Route("customers")]
        [HttpGet]
        public ICollection<Customer> GetCus()
        {
            return _jacketRepository.GetCustomers();
        }

        [Route("customers/{cus_id}")]
        [HttpGet]
        public IQueryable<Customer> GetCustomerById(int cus_id)
        {
            return _jacketRepository.GetCustomerById(cus_id);
        }

        [Route("customers")]
        [HttpPost]
        public async Task<IActionResult> PostCus(Customer newCustomer)
        {
            try
            {
                if (newCustomer == null)
                {
                    return StatusCode(400);
                }

                await _jacketRepository.InsertCustomer(newCustomer);
                return StatusCode(200);

            } catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [Route("orders")]
        [HttpGet]
        public ICollection<Order> GetOrders()
        {
            return _jacketRepository.GetOrders();
        }

        [Route("orders/{order_id}")]
        [HttpGet]
        public IQueryable<Order> GetOrderById(int order_id)
        {
            return _jacketRepository.GetOrderById(order_id);
        }

        [Route("products")]
        [HttpGet]
        public ICollection<Product> GetProducts()
        {
            return _jacketRepository.GetProducts();
        }

        [Route("products/{prod_id}")]
        [HttpGet]
        public IQueryable<Product> GetProductById(int prod_id)
        {
            return _jacketRepository.GetProductById(prod_id);
        }

        [Route("products/{prod_id}/{ware_id}")]
        [HttpGet]
        public IQueryable<WarehouseProduct> GetProductInWarehouse(int prod_id, int ware_id)
        {
            return _jacketRepository.GetProuctByWarehouse(prod_id, ware_id);
        }

        [Route("addresses")]
        [HttpGet]
        public ICollection<Address> GetAddresses()
        {
            return _jacketRepository.GetAddresses();
        }

        [Route("addresses/{address_id}")]
        [HttpGet]
        public IQueryable<Address> GetAddressesById(int address_id)
        {
            return _jacketRepository.GetAddressById(address_id);
        }

        [Route("addresses/street/{street}")]
        [HttpGet]
        public ICollection<Address> GetAddressesByStreet(string street)
        {
            return _jacketRepository.GetAddressesByStreet(street);
        }

        [Route("warehouses")]
        [HttpGet]
        public ICollection<Warehouse> GetWarehouses()
        {
            return _jacketRepository.GetWarehouses();
        }

        [Route("warehouses/{ware_id}")]
        [HttpGet]
        public IQueryable<Warehouse> GetWarehouseById(int ware_id)
        {
            return _jacketRepository.GetWarehouseById(ware_id);
        }

        [Route("warehouses/{ware_id}/products")]
        [HttpGet]
        public ICollection<WarehouseProduct> GetWarehouseProducts(int ware_id)
        {
            return _jacketRepository.GetAllProductsAtWarehouse(ware_id);
        }

        [Route("warehouses/{ware_id}/address")]
        [HttpGet]
        public IQueryable<Address> GetWarehouseAddress(int ware_id)
        {
            return _jacketRepository.GetWarehouseAddress(ware_id);
        }

    }
}
