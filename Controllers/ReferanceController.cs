using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebPanel.Controllers
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
		public IActionResult ReferanceAdd(Referance referance)
		{
			referanceManager.Add(referance);
			return RedirectToAction("Index","Referance");
		} 


		public IActionResult ReferanceDelete(int id)
        {
			var result = referanceManager.Get(id);
			referanceManager.Delete(result);
			return RedirectToAction("Index");

		}
	}
}
