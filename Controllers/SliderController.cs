using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace celebiUI.Controllers
{
    public class SliderController : Controller
    {
        SliderManager sliderManager= new SliderManager(new EfSliderDal());   
        public IActionResult Index()
        {
            var result = sliderManager.GetAll();
            return View(result);
        }
    }
}
