using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class testController : Controller
    {
        public IActionResult Index()
        {
            return Content("hes");
        }
    }
}
