using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.Controllers
{
    public class EnHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
