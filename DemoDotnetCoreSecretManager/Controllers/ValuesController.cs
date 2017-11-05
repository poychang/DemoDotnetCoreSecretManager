using DemoDotnetCoreSecretManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DemoDotnetCoreSecretManager.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly AppSettings settings;

        public ValuesController(IOptions<AppSettings> options)
        {
            settings = options.Value;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(settings);
        }
    }
}
