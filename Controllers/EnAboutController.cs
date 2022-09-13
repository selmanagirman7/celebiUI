using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace celebiUI.Controllers
{
    public class EnAboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        public IActionResult Index()
        {
            var result = aboutManager.GetAll();
            return View(result);
        }
    }
}
