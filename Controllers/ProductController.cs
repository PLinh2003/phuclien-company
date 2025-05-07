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
            var products = await _productRepository.GetAllAsync();
            return View(model: new ProductIndexViewModel
            {
                Products = products
            });
        }
    }
}