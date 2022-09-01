using Microsoft.AspNetCore.Mvc;
using Fulbo12.Core.Persistencia;
using Fulbo12.Core.Persistencia.Excepciones;

namespace Fulbo12.Core.Mvc.Controllers;

public class PaisController : Controller
{
    private readonly IUnidad _unidad;

    public PaisController(IUnidad unidad) => _unidad = unidad;
    public async Task<IActionResult> Index(byte? id)
    {
        if (id is null || id == 0)
        {
            var paises = await _unidad.RepoPais.ObtenerAsync
                            (orden: ps => ps.OrderBy(p => p.Nombre));
            return View(paises);
        }

        var pais = await _unidad.RepoPais.ObtenerPorIdAsync(id);
        if (pais is null)
            return NotFound();
        var ligas = await _unidad.RepoLiga.LigasDeAsync(pais);
        return View("Detalle", ligas);
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
        try
        {
            await _unidad.GuardarAsync();
        }
        catch (EntidadDuplicadaException e)
        {
            return NotFound();
        }
        return RedirectToAction(nameof(Index));
    }
}
