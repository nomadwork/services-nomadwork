using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Nomadwork.Controllers
{
    [ApiController]
    [Route("")]

    public class IndexController : ControllerBase
    {
        [HttpGet]
        //[ActionName("Index")]
        [Route("")]

        public IActionResult Index()
        {

            var file = Path.Combine(Directory.GetCurrentDirectory(),
                "ClientApp", @"dist\nomadwork\index.html");

            return PhysicalFile(file,"text/html");

        }
    }
}
