using Microsoft.AspNetCore.Mvc;

namespace YoutubeProjet.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
