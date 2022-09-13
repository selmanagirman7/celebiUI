using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace celebiUI.Controllers
{
    public class EnProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        

        public IActionResult Index()
        {
            var result = productManager.GetAll();
            return View(result);
        }
    }
}
