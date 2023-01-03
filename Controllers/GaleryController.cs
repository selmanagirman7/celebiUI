using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using WebPanel.Models;

namespace WebPanel.Controllers
{
	public class GaleryController : Controller
	{
		GaleryManager galeryManager = new GaleryManager(new EfGaleyDal());
		public IActionResult Index()
		{
			var result = galeryManager.GetAll();
			return View(result);
		}


		[HttpGet]
		public IActionResult GaleryAdd()
		{
			return View();
		}


		[HttpPost]
		public IActionResult GaleryAdd(GaleryAdd galery)
		{
			Galery g = new Galery();
            if (galery.ImagePath != null)
            {

				var extension=Path.GetExtension(galery.ImagePath.FileName);
				var newguid =Guid.NewGuid()+extension;
				var location=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/"+ newguid );
				var stream = new FileStream(location, FileMode.Create);
				galery.ImagePath.CopyTo(stream);
				g.ImagePath = newguid;

            }

			g.PageTitleEng = galery.PageTitleEng;
			g.PageTitle=galery.PageTitle;
			
			galeryManager.Add(g);

			return RedirectToAction("Index");
		}
		public IActionResult GaleryDelete(int id) 
		{
			var result = galeryManager.Get(id);
			galeryManager.Delete(result);
			return RedirectToAction("Index");	
		}

	}
}
