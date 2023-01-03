using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.Controllers
{
    public class EnReferanceController : Controller
    {
        ReferanceManager referanceManager = new ReferanceManager(new EfReferanceDal());
        public IActionResult Index()
        {
            var result = referanceManager.GetAll();
            return View(result);
        }
    }
}
