using WebTabanlıProgramlama_1ODEV.Models;
using Microsoft.AspNetCore.Mvc;


namespace WebTabanlıProgramlama_1ODEV.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>();
        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]

        public IActionResult Update(Product p)
        {
            products.Add(p);
            return View("Index",products);
        }
    }
}
