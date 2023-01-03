using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebPanel.Controllers
{
	public class ServiceController : Controller
	{
		OurServiceManager ourServiceManager = new OurServiceManager(new EfOurServiceDal());
		public IActionResult Index()
		{
			var result = ourServiceManager.GetAll();

			return View(result);
		}


		[HttpGet]
		public IActionResult ServiceAdd()
		{
			return View();
		}


		[HttpPost]
		public IActionResult ServiceAdd(OurService ourService)
		{
			ourServiceManager.Add(ourService);
			return RedirectToAction("Index","Service");
		}
		
		public IActionResult ServiceDelete(int id)
        {
			var result = ourServiceManager.Get(id);
			ourServiceManager.Delete(result);
			return RedirectToAction("Index");
        }
	}
}
