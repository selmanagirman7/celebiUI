using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using KaradumanRafUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace KaradumanRafUI.Controllers
{
    public class ReferanceController : Controller
    {
        ReferanceManager referanceManager = new ReferanceManager(new EfReferanceDal()); 
        public IActionResult Index()
        {
            var result = referanceManager.GetAll();
            return View(result);
        }



        [HttpGet]
        public IActionResult ReferanceAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ReferanceAdd(ReferanceAdd referanceAdd)
        {
            Referance referance = new Referance();
            if (referanceAdd.ImagePath!=null)
            {
                var extension = Path.GetExtension(referanceAdd.ImagePath.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + newguid);
                var stream = new FileStream(location, FileMode.Create);
                referanceAdd.ImagePath.CopyTo(stream);
                referance.ImagePath = newguid;

            }

            referance.ReferanceName=referanceAdd.ReferanceName;
            referance.ReferanceNameEng = referanceAdd.ReferanceNameEng;
            

            referanceManager.Add(referance);
            return RedirectToAction("Index", "Referance");
        }

    }
}
