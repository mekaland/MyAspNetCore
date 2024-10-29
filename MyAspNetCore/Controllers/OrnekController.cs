using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCore.Controllers
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    
    }
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            var productlist = new List<Product>()
            {
                new(){Id=1 , Name="kalem"},
                new(){Id=2 , Name="Silgi"},
                new(){Id=3 , Name="Cüzdanlık"}

            };

            //ViewBag.name = "Ahmet";
            
            ///TempData["surname"] = "yıldız";
            return View(productlist);
        }

        public IActionResult ContentResult()
        {
            return Content("Content result");
        }

        public IActionResult Index2()
        {
           // return RedirectToAction("Index","Ornek");
           return View();
        }
    }
}
