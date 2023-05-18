using Microsoft.AspNetCore.Mvc;
using System;

namespace Ecommerce.Controllers
{
    [ApiController]
    [Route("/")]
    public class PingController : BaseController
    {
        [HttpGet]
        
        public JsonResult Ping()
        {
            return new JsonResult(new { status = true, debuggText = DateTime.Now });
        }
    }
}
