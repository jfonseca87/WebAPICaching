using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApi.OutputCache.V2;
using WebAPICachingNet.Models;

namespace WebAPICachingNet.Controllers
{
    public class TestController : ApiController
    {
        [Route("api/test")]
        [HttpGet]
        [CacheOutput(ClientTimeSpan = 43200, ServerTimeSpan = 43200)]
        public IEnumerable<TestTable1> Test()
        {
            using (var db = new CachingContext())
            {
                db.Configuration.LazyLoadingEnabled = false;
                var data = db.TestTable1.ToList();

                return data;
            }
        }

    }
}