using Fulbo12.Core.Futbol;
using Fulbo12.Core.Mvc.ViewModels;
using Fulbo12.Core.Persistencia;
using Fulbo12.Core.Persistencia.Excepciones;
using Microsoft.AspNetCore.Mvc;

namespace Fulbo12.Core.Mvc.Controllers;
public class LigaController : Controller
{
    private readonly IUnidad _unidad;
    public LigaController(IUnidad unidad) => _unidad = unidad;

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Alta()
    {
        var paises = await _unidad.RepoPais.ObtenerAsync
                        (orden: ps => ps.OrderBy(p => p.Nombre));
        var vmLiga = new VMLiga(paises);
        return View("Upsert", vmLiga);
    }

    [HttpPost]
    public async Task<IActionResult> Upsert(VMLiga vmLiga)
    {
        if (vmLiga.IdLiga == 0)
        {
            var pais = await _unidad.RepoPais.ObtenerPorIdAsync(vmLiga.IdPais);
            var liga = new Liga(vmLiga.NombreLiga!, pais);
            liga.Equipos = new List<Equipo>();
            await _unidad.RepoLiga.AltaAsync(liga);
        }

        try
        {
            await _unidad.GuardarAsync();
        }
        catch (EntidadDuplicadaException e)
        {
            return NotFound();
        }

        return RedirectToAction("Index", "Home");
    }
}
