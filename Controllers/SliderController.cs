using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using KaradumanRafUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace KaradumanRafUI.Controllers
{
    public class SliderController : Controller
    {
        SliderManager sliderManager = new SliderManager(new EfSliderDal());
        public IActionResult Index()
        {
            var result = sliderManager.GetAll();
            return View();
        }

        [HttpGet]
        public IActionResult SliderAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SliderAdd(SliderAdd slider)
        {
            Slider p = new Slider();
            if (slider.ImgPath != null)
            {

                var extension = Path.GetExtension(slider.ImgPath.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + newguid);
                var stream = new FileStream(location, FileMode.Create);
                slider.ImgPath.CopyTo(stream);
                p.ImgPath = newguid;

            }


            if (slider.ImgPath != null)
            {

                var extension = Path.GetExtension(slider.ImgPath.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + newguid);
                var stream = new FileStream(location, FileMode.Create);
                slider.ImgPath.CopyTo(stream);
                p.ImgPath = newguid;

            }


            if (slider.ImgPath != null)
            {

                var extension = Path.GetExtension(slider.ImgPath.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + newguid);
                var stream = new FileStream(location, FileMode.Create);
                slider.ImgPath.CopyTo(stream);
                p.ImgPath = newguid;

            }


            p.SliderText = slider.SliderText;
            p.SliderText2 = slider.SliderText2;
            p.SliderText3 = slider.SliderText3;
            p.SliderText4 = slider.SliderText4;
            p.SliderText5 = slider.SliderText5;



            sliderManager.Add(p);
            return RedirectToAction("AddSlider", "Slider");
        }
    }
}
