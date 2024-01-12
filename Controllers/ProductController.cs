using AspNetMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new List<Product>
            {
                new Product { ID = 1, Name = "Xiaomi", Price = 50.99, CreatedDate = DateTime.Now },
                new Product { ID = 2, Name = "Apple", Price = 1500.80, CreatedDate = DateTime.Now.AddMinutes(-15) },
                new Product { ID = 3, Name = "Asus", Price = 45.99, CreatedDate = DateTime.Now.AddDays(-2) }
            };
            return View(product);
        }
    }
}
