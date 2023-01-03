using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KaradumanRafUI.Controllers
{
    public class EnContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal()); 
        public IActionResult Index()
        {
            var result = contactManager.GetAll();
            return View(result);
        }
    }
}
