using Makyr.DataAccess.Repository.IRepository;
using Makyr.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakyrWeb.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGraphicsCardRepository _graphicsCardRepository;

        public ProductController(IGraphicsCardRepository graphicsCardRepository)
        {
            _graphicsCardRepository = graphicsCardRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<GraphicsCard> gpus = _graphicsCardRepository.GetAll();
            return View(gpus);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(GraphicsCard gpu)
        {
            if(gpu.Quantity > 0)
            {
                gpu.IsInStock = true;
            }

            if (ModelState.IsValid)
            {
                _graphicsCardRepository.Add(gpu);
                _graphicsCardRepository.Save();
                TempData["success"] = "Product added successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}
