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

        [Route("customers")]
        [HttpPost]
        public HttpResponseMessage PostCus(Customer newCustomer)
        {
            try
            {
                if (newCustomer == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest);
                }

                _jacketRepository.InsertCustomer(newCustomer);
                return new HttpResponseMessage(HttpStatusCode.OK);


            } catch (Exception)
            {
                return new HttpResponseMessage
                {
                    Content = new StringContent("Error creating new customer"),
                    StatusCode = HttpStatusCode.InternalServerError,
                };
            }
        }

    }
}
