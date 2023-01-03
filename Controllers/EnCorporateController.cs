using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.Controllers
{
    public class EnCorporateController : Controller
    {
        CorporateManager corporateManager=new CorporateManager(new EfCorporateDal());
        public IActionResult Index()
        {
            var result = corporateManager.GetAll();
            return View(result);
        }
    }
}
