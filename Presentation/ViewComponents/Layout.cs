using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace Presentation.ViewComponents
{
    public class Header : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
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
    public class CategoryProducts : ViewComponent { public IViewComponentResult Invoke() { return View(); } }
    public class CategoryTab:ViewComponent { public IViewComponentResult Invoke() { return View(); } }
}
