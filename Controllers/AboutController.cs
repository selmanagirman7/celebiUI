using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebPanel.Controllers
{
	public class AboutController : Controller
	{
		AboutManager aboutManager = new AboutManager(new EfAboutDal());
		[HttpGet]
		public IActionResult Index()
		{
			var result = aboutManager.GetAll();
			return View(result);
		}


		[HttpGet]
		public IActionResult AboutAdd()
		{

			return View();
		}

		[HttpPost]
		public IActionResult AboutAdd(About about)
		{



			aboutManager.Add(about);
			return RedirectToAction("Index","About");
		}


	
	
		public IActionResult AboutDelete(int id)
        {
			var result = aboutManager.Get(id);
			aboutManager.Delete(result);
			return RedirectToAction("Index");
        }


		[HttpGet]
		public IActionResult AboutUpdate(int id)
        {
			var result=aboutManager.Get(id);
			return View(result);
        }


		[HttpPost]
		public IActionResult AboutUpdate(About about)
        {
			aboutManager.Update(about);
			return RedirectToAction("Index");
        }
	}
}
