using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class AdvertController : Controller
    {
        BookAdManager bookAdManager = new BookAdManager(new EfBookAdRepository());
        BookManager bookManager = new BookManager(new EfBookRepository());
        UserManager userManager = new UserManager(new EfUserRepository());
        [AllowAnonymous]
        public IActionResult Index(int id)
        {
            var data = bookAdManager.GetById(id);
            return View(data);
        }
        [AllowAnonymous]
        public IActionResult List()
        {
            var data = bookAdManager.GetAllByIncludes();
            return View(data);
        }
        public IActionResult AddAdvert()
        {
            var data = bookManager.GetListAll();
            return View(data);
        }
        [HttpPost]
        public IActionResult AddAdvert(BookAd bookAd)
        {
            try
            {
                var user = userManager.GetUserByEmail(User.Identity.Name);
                BookAd newAdvert = new BookAd();
                newAdvert.Title = bookAd.Title;
                newAdvert.Description = bookAd.Description;
                newAdvert.Price = bookAd.Price;
                newAdvert.UserId = user.Id;
                newAdvert.BookId = bookAd.BookId;
                newAdvert.Images = bookAd.Images;
                newAdvert.BookAdStatus = true;
                bookAdManager.Add(newAdvert);
                return RedirectToAction("Index","Home");
            }
            catch (Exception)
            {

                return View();
            }
           
        }
        [HttpPost]
        public IActionResult UploadImage(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                var filePath = Path.Combine(uploadFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                var fileUrl = $"/uploads/{fileName}";

                return Json(new { success = true, message = "Dosya başarıyla yüklendi.", url = fileUrl });
            }

            return Json(new { success = false, message = "Dosya yükleme sırasında bir hata oluştu." });
        }

    }
}
