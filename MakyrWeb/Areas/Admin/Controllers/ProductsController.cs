using Makyr.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace MakyrWeb.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IGraphicsCardRepository _graphicsCardRepository;

        public ProductsController(IGraphicsCardRepository graphicsCardRepository)
        {
            _graphicsCardRepository = graphicsCardRepository;
        }


    }
}
