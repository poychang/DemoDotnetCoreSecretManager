using Microsoft.AspNetCore.Mvc;

namespace DemoDotnetCoreSecretManager.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return new EmptyResult();
        }
    }
}
