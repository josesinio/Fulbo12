using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fulbo12.Core.Mvc.Models;

namespace Fulbo12.Core.Mvc.Controllers;

public class LigaController : Controller
{
    private readonly ILogger<LigaController> _logger;

    public LigaController(ILogger<LigaController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
