using Microsoft.AspNetCore.Mvc;
using phuclien_company.Interfaces;
using phuclien_company.ViewModels;

namespace phuclien_company.Controllers
{
    public class ProductController(ILogger<ProductController> logger, IProductRepository productRepository) : Controller
    {
        private readonly ILogger<ProductController> _logger = logger;
        private readonly IProductRepository _productRepository = productRepository;

        public async Task<IActionResult> Index()
        {
            return View(model: new ProductIndexViewModel
            {
                Products = await _productRepository.GetAllAsync()
            });
        }

        public async Task<IActionResult> Details(int id)
        {
            await Task.Delay(1);
            return View();
        }
    }
}