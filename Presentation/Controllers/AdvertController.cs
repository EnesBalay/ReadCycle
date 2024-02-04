using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class AdvertController : Controller
    {
        BookAdManager bookAdManager = new BookAdManager(new EfBookAdRepository());
        [AllowAnonymous]
        public IActionResult Index(int id)
        {
            var data=bookAdManager.GetById(id);
            return View(data);
        }
        [AllowAnonymous]
        public IActionResult List()
        {
            var data = bookAdManager.GetListAll();
            return View(data);
        }
        public IActionResult AddAdvert()
        {
            return View();
        }
        
    }
}
