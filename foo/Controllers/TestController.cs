using Microsoft.AspNet.Mvc;
using System.Collections.Generic;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] {"1", "two", "III"};
        }
    }
}