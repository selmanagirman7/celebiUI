using Microsoft.AspNetCore.Mvc;

namespace celebiUI.Controllers
{
    public class EnHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
