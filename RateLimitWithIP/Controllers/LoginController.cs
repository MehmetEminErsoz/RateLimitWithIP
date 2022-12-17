using Microsoft.AspNetCore.Mvc;

namespace RateLimitWithIP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController
    {
        [HttpPost]
        [Route("/login")]
        
        public bool Login ()
        {
            return true;
        }
    }
}
