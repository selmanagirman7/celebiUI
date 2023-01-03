using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.Controllers
{
    public class EnGaleryController : Controller
    {
        GaleryManager galeryManager= new GaleryManager(new EfGaleyDal());
        public IActionResult Index()
        {
            var result = galeryManager.GetAll();
            return View(result);
        }
    }
}
