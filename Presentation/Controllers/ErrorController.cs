using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            // Özelleştirilmiş 404 sayfasına yönlendirme
            if (statusCode == 404)
            {
                return View("NotFound");
            }

            return View("Error");
        }
    }
}
