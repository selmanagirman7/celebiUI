using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace celebiUI.Controllers
{
    public class OurServiceController : Controller
    {
        OurServiceManager ourServiceManager = new OurServiceManager(new EfOurServiceDal());
        public IActionResult Index()
        {
            var result = ourServiceManager.GetAll();
            return View(result);
        }
    }
}
