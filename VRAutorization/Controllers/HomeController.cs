using Microsoft.AspNetCore.Mvc;

namespace VRAutorization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController: ControllerBase
    {

        [HttpGet]
        string Get()
        {
            return "Hello World";
        }
    }
    
    
}