using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Jacket_Store.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JacketController : ControllerBase
    {

        private readonly ILogger<JacketController> _logger;

        JacketController(ILogger<JacketController> logger)
        {
            _logger = logger;
        }
    }
}
