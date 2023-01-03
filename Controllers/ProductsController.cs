using Business.Concrete;
using DataAccess.Concrete;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using WebPanel.Models;

namespace WebPanel.Controllers
{
    public class ProductsController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());


        [HttpGet]
        public IActionResult Index()
        {
            var result = productManager.GetAll();
            return View(result);
        }


        [HttpGet]
        public IActionResult ProductAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ProductAdd(ProductAdd product)
        {

            Product p = new Product();
            if (product.ImgPath != null)
            {

                var extension = Path.GetExtension(product.ImgPath.FileName);
                var newguid = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + newguid);
                var stream = new FileStream(location, FileMode.Create);
                product.ImgPath.CopyTo(stream);
                p.ImgPath = newguid;

            }

            p.ProductName = product.ProductName;
            p.ProductNameEng = product.ProductNameEng;  
            p.Metarial=product.Metarial;
            p.Dimensions = product.Dimensions;
            p.BoxSize = product.BoxSize;
            p.MetarialEng = product.MetarialEng;
            p.BoxSizeEng = product.BoxSizeEng;  
            p.DimensionsEng = product.DimensionsEng;
            p.SeatAngleEng = product.SeatAngleEng;
            p.TotalWeight = product.TotalWeight;    
            p.TotalWeightEng = product.TotalWeightEng;  
            p.SeatAngle = product.SeatAngle;
            p.SeatAngleEng = product.SeatAngleEng;
           
           


            productManager.Add(p);    
            return RedirectToAction("Index","Products");
        }
    
            
        public IActionResult ProductDelete(int id)
        {
            var result = productManager.Get(id);    
            productManager.Delete(result);
            return RedirectToAction("Index");
        }
    }
}
