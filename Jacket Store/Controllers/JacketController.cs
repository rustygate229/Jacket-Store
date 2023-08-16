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

        [Route("customers/{id}")]
        [HttpGet]
        public IQueryable<Customer> GetCustomerById(int id)
        {
            return _jacketRepository.GetCustomerById(id);
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

        [Route("products")]
        [HttpGet]
        public ICollection<Product> GetProducts()
        {
            return _jacketRepository.GetProducts();
        }

        [Route("addresses")]
        [HttpGet]
        public ICollection<Address> GetAddresses()
        {
            return _jacketRepository.GetAddresses();
        }

        [Route("warehouses")]
        [HttpGet]
        public ICollection<Warehouse> GetWarehouses()
        {
            Console.WriteLine("Received Request..");
            return _jacketRepository.GetWarehouses();
        }

    }
}
