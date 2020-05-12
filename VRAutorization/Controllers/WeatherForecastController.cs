using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VRAutorization.Calsses;

namespace VRAutorization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private Worker w;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            w = new Worker();
        }

        [HttpGet]
        public string Home()
        {
            return GetSHA256("1");
            return 0.ToString();
        }
        
        public static string GetSHA256(string word)
        {
            using (SHA256 cr = SHA256.Create())
            {
                var sBuilder = new StringBuilder();
                byte[] _tempB = cr.ComputeHash(Encoding.UTF8.GetBytes(word));

                for (int i = 0; i < _tempB.Length; i++)
                {
                    sBuilder.Append(_tempB[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }

        
        [HttpGet("valid")]
        public string CheckGetRequest(string email, string pass)
        {
            return itemDataBase.Validate(w.JsonDataBase, email, pass).ToString();
        }


        [HttpPost]
        public string testpost()
        {
            return "postComplete";
        }


    }
    
    
}