using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebPanel.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());

        [HttpGet]
        public IActionResult Index()
        {var result = contactManager.GetAll();  
            return View(result);
        }



        [HttpGet]
        public IActionResult ContactAdd()
		{
            return View();  
		}

        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
		{
            contactManager.Add(contact);    
            return RedirectToAction("Index","Contact");
		}
    
        public IActionResult ContactDelete(int id)
        {
            var result = contactManager.Get(id); 
            contactManager.Delete(result);
            return RedirectToAction("Index");
        }

    }
}
