using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
