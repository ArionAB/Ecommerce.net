using Ecommerce.DataLayer.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        // Returns the current authenticated account (null if not logged in)
        public BaseUser Account => (BaseUser)HttpContext.Items["User"];


    }
}
