using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace celebiUI.Controllers
{
    public class ReferanceController : Controller
    {
        ReferanceManager referanceManager = new ReferanceManager(new EfReferanceDal());
        public IActionResult Index()
        {
            var result = referanceManager.GetAll();
            return View(result);
        }
    }
}
