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

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GraphicsCard gpu = await _graphicsCardRepository.GetAsync(x => x.Id == id);

            if (gpu == null)
            {
                return NotFound();
            }
            return View(gpu);
        }

        [HttpPost]
        public IActionResult Edit(GraphicsCard gpu)
        {
            if (gpu.Quantity > 0)
            {
                gpu.IsInStock = true;
            }

            if (ModelState.IsValid)
            {
                _graphicsCardRepository.Update(gpu);
                _graphicsCardRepository.Save();
                TempData["success"] = "Gpu data updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            GraphicsCard? obj = await _graphicsCardRepository.GetAsync(x => x.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(GraphicsCard gpu)
        {
            if (gpu == null)
            {
                return NotFound();
            }

            _graphicsCardRepository.Remove(gpu);
            _graphicsCardRepository.Save();
            TempData["error"] = "Gpu data deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
