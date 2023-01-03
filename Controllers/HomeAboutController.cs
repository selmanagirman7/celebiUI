using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebPanel.Controllers
{
	public class HomeAboutController : Controller
	{
		HomeAboutManager homeAboutManager = new HomeAboutManager(new EfHomeAboutDal());
		public IActionResult Index()
		{
			var result = homeAboutManager.GetAll();
			return View(result);
		}

		[HttpGet]
		public IActionResult HomeAboutAdd()
		{
			return View();
		}

		[HttpPost]
		public IActionResult HomeAboutAdd(HomeAbout homeAbout)
		{
			homeAboutManager.Add(homeAbout);
			return RedirectToAction("Index", "HomeAbout");
		}
		public IActionResult HomeDelete(int id)
		{
			var result = homeAboutManager.Get(id);
			homeAboutManager.Delete(result);
			return RedirectToAction("Index");


        }

		
	}
}
