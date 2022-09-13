using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace celebiUI.Controllers
{
    public class CorporateController : Controller
    {
        CorporateManager corporateManager = new CorporateManager(new EfCorporateDal());

        public IActionResult Index()
        {
            var result = corporateManager.GetAll();
            return View(result);
        }
    }
}
