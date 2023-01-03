using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebPanel.Controllers
{
	public class CategoryController : Controller
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
		public IActionResult Index()
		{
			var result = categoryManager.GetAll();
			return View(result);
		}
		
		[HttpGet]
		public IActionResult CategoryAdd()
		{
			return View();	
		}

		[HttpPost]
		public IActionResult CategoryAdd(Category category)
		{
			categoryManager.Add(category);	
			return RedirectToAction("Index","Category");
		}



		public IActionResult CategoryDelete(int id)
        {
			var result = categoryManager.Get(id);
			categoryManager.Delete(result);
			return RedirectToAction("Index");
        }
	
	}
}
