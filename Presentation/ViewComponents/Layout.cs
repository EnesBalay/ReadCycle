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
            var user = userManager.GetUserByEmail(User.Identity.Name);
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
    public class FeaturesItems : ViewComponent
    {
        BookAdManager bookAdManager = new BookAdManager(new EfBookAdRepository());
        public IViewComponentResult Invoke()
        {
            var data = bookAdManager.GetAllByIncludes();
            return View(data);
        }
    }
    public class CategoryProducts : ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            List<Category> categories = categoryManager.GetListAll();
            return View(categories);
        }
    }
    public class Writers : ViewComponent
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            List<Writer> writers = writerManager.GetListAll();
            return View(writers);
        }
    }
    public class CategoryTab : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    public class RecommendedItems : ViewComponent { public IViewComponentResult Invoke() { return View(); } }
    public class LeftSidebar : ViewComponent { public IViewComponentResult Invoke() { return View(); } }

}
