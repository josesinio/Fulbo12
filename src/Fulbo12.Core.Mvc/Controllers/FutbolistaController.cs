using Fulbo12.Core.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fulbo12.Core.Mvc.Controllers
{
    private readonly IUnidad _unidad;
    public class FutbolistaController : Controller
    {
        public FutbolistaController(IUnidad unidad) => _unidad = unidad;

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}