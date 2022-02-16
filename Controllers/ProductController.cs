using Activity3b.Models;
using Activity3b.ServiceProduct;
using Microsoft.AspNetCore.Mvc;

namespace Activity3b.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            HardCodedDataRepository hardCodedDataRepository = new HardCodedDataRepository();
            return View(hardCodedDataRepository.GetAllProducts());
        }
        public IActionResult Message()
        {
            return View("Message");
        }
        public IActionResult Welcome(string name,int secretNumber=13)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
