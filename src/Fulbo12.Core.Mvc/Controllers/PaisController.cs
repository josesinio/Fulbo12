using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fulbo12.Core.Mvc.Models;
using Fulbo12.Core.Persistencia;

namespace Fulbo12.Core.Mvc.Controllers;

public class PaisController : Controller
{
    private readonly IUnidad _unidad;

    public PaisController(IUnidad unidad) => _unidad = unidad;
    public async Task<IActionResult> Index()
    {
        var paises = await _unidad.RepoPais.ObtenerAsync
            (orden: ps => ps.OrderBy(p => p.Nombre));
        return View(paises);
    }
    [HttpGet]
    public IActionResult Alta()
    {
        return View("Upsert");
    }
    [HttpPost]
    public async Task<IActionResult> Upsert(Pais pais)
    {
        await _unidad.RepoPais.AltaAsync(pais);
        await _unidad.GuardarAsync();
        return RedirectToAction("Index");
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
