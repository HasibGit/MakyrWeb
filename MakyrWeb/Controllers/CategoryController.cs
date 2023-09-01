using Microsoft.AspNetCore.Mvc;

namespace MakyrWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
