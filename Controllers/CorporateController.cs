using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebPanel.Controllers
{
	public class CorporateController : Controller
	{
		CorporateManager corporateManager=new CorporateManager(new EfCorporateDal());
		public IActionResult Index()
		{
			var result = corporateManager.GetAll();
			return View(result);
		}



		[HttpGet]
		public IActionResult CorporateAdd()
		{
			return View();	
		}

		[HttpPost]
		public IActionResult CorporateAdd(Corporate corporate)
		{
			corporateManager.Add(corporate);
			return RedirectToAction("Index","Coporate");
		}


		public IActionResult CorporateDelete(int id)
        {

			var result = corporateManager.Get(id);
			corporateManager.Delete(result);
			return RedirectToAction("Index");

        }

	}
}
