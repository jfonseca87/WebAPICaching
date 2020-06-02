using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPICaching.Models;

namespace WebAPICaching.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TestContext db;
        private readonly ILogger logger;

        public TestController(ILogger<TestController> _logger, TestContext _db)
        {
            db = _db;
            logger = _logger;
        }

        [ResponseCache(Duration = 60)]
        [Route("api/test")]
        [HttpGet]
        public IActionResult Test()
        {
            logger.LogInformation("Ingreso al endpoint");

            var result = db.TestTable1.ToList();
            return Ok(result);
        }
    }
}
