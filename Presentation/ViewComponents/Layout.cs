using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace Presentation.ViewComponents
{
    public class Header : ViewComponent
    {
        UserManager userManager = new UserManager(new EfUserRepository());
        public IViewComponentResult Invoke()
        {
            var user= userManager.GetUserByEmail(User.Identity.Name);
            Console.WriteLine(user);
            return View(user);
        }
    }
    public class Footer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    public class Slider : ViewComponent { public IViewComponentResult Invoke() { return View(); } }
    public class FeaturesItems : ViewComponent { public IViewComponentResult Invoke() { return View(); } }
    public class CategoryProducts : ViewComponent {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke() {
            List<Category> categories = categoryManager.GetListAll();
            return View(categories); } 
    }    
    public class Writers : ViewComponent { 

        public IViewComponentResult Invoke() { 

            return View(); } 
    }
    public class CategoryTab : ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            List<Category> categories = categoryManager.GetListAll();
            return View(categories);
        }
    }
    public class RecommendedItems : ViewComponent { public IViewComponentResult Invoke() { return View(); } }
}
