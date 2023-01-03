using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManeger = new CategoryManager(new EfCategoryDal());
     
        public IActionResult Index()
        {
            var result = categoryManeger.GetAll();

            return View(result);
        }
    }
}
