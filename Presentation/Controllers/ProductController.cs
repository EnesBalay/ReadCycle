using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class ProductController : Controller
    {
        BookAdManager bookAdManager = new BookAdManager(new EfBookAdRepository());
        public IActionResult Index(int id)
        {
            var data=bookAdManager.GetById(id);
            return View(data);
        }
        public IActionResult GetAllProduct()
        {
            var data = bookAdManager.GetListAll();
            return View(data);
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        
    }
}
