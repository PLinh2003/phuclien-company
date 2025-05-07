using Microsoft.AspNetCore.Mvc;

namespace phuclien_company.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public async Task<IActionResult> Index()
    {
        await Task.Delay(1000);
        return View();
    }
}
