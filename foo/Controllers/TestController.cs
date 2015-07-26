using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

namespace MvcSample.Web
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] {"1", "two", "III"};
        }
    }
}