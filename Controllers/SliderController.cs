using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebPanel.Controllers
{
    public class SliderController : Controller
    {
        SliderManager sliderManager = new SliderManager(new EfSliderDal());

        public IActionResult Index()
        {
            var result=sliderManager.GetAll();
            return View(result);
        }


        [HttpGet]
        public IActionResult SliderAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SliderAdd(Slider slider)
        {
            sliderManager.Add(slider);  
            return RedirectToAction("Index","Slider");
        }

        public IActionResult SliderDelete(int id)
        {
            var result = sliderManager.Get(id);
            sliderManager.Remove(result);
            return RedirectToAction("Index");
        }
    }
}
