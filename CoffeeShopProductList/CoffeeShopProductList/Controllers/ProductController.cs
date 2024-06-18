using CoffeeShopProductList.Data;
using CoffeeShopProductList.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopProductList.Controllers
{
    public class ProductController : Controller
    {
        private ProductDbContext _db;

        public ProductController(ProductDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {   var product = _db.Products.ToList();
            return View(product);
        }

        [HttpGet]
        public IActionResult Detail(int id)
        {
            var product = _db.Products.Find(id);
            if (product == null)
            {
                return View("Index");
            }

            return View(product);
        }

    }
}
