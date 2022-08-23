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
    [HttpGet]
    public async Task<IActionResult> Modificar(byte? id)
    {
        if (id is null || id == 0)
            return NotFound();

        var pais = await _unidad.RepoPais.ObtenerPorIdAsync(id);
        if (pais is null)
            return NotFound();

        return View("Upsert", pais);
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Upsert(Pais pais)
    {
        if (pais.Id == 0)
            await _unidad.RepoPais.AltaAsync(pais);
        else
        {
            var paisRepo = await _unidad.RepoPais.ObtenerPorIdAsync(pais.Id);
            if (paisRepo is null)
                return NotFound();
            paisRepo.Nombre = pais.Nombre;
            _unidad.RepoPais.Modificar(paisRepo);
        }
        await _unidad.GuardarAsync();
        return RedirectToAction(nameof(Index));
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
