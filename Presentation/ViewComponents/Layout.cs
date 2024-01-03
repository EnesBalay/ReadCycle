using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;


namespace Presentation.ViewComponents
{
    public class Header:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }    
    public class Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
