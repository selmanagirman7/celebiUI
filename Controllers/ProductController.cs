using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace celebiUI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public IActionResult Index()
        {
            var result = productManager.GetAll();
            return View(result);
        }
        public IActionResult ProductDetail(int id)
        {
            var result = productManager.GetProductById(id);
            return View(result);
        }
    }
}
