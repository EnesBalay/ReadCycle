using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class ContactContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
