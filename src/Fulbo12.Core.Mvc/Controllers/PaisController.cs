using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fulbo12.Core.Mvc.Models;
using Fulbo12.Core.Persistencia;

namespace Fulbo12.Core.Mvc.Controllers;

public class PaisController : Controller
{
    private readonly IUnidad _unidad;

    public PaisController(IUnidad unidad) => _unidad = unidad;

    public IActionResult Index()
    {
        var paises = _unidad.RepoPais.Obtener(); 
        return View(paises);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
