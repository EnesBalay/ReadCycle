using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        
    }
}
