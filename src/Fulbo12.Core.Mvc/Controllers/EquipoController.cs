using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Fulbo12.Core.Mvc.Models;
using Fulbo12.Core.Mvc.ViewModels;
using Fulbo12.Core.Persistencia;
using Fulbo12.Core.Futbol;
using Fulbo12.Core.Persistencia.Excepciones;

namespace Fulbo12.Core.Mvc.Controllers;

public class EquipoController : Controller
{
    private readonly IUnidad _unidad;
    public EquipoController(IUnidad unidad) => _unidad = unidad;

    public async Task<IActionResult> Index()
    {
        var equipos = await _unidad.RepoEquipo.ObtenerAsync
            (orden: es => es.OrderBy(e => e.Nombre),
            includes: "Liga");
        return View(equipos);
    }

    [HttpGet]
    public async Task<IActionResult> Alta()
    {
        var ligas = await _unidad.RepoLiga.ObtenerAsync
                        (orden: ls => ls.OrderBy(l => l.Nombre));
        var vmEquipo = new VMEquipo(ligas);
        return View("Upsert", vmEquipo);
    }

    [HttpPost]
    public async Task<IActionResult> Upsert(VMEquipo VMequipo)
    {
        if (!ModelState.IsValid)
            return View("Upsert", VMequipo);

        if (VMequipo.IdEquipo == 0)
        {
            var liga = await _unidad.RepoLiga.ObtenerPorIdAsync(VMequipo.IdLiga);
            var equipo = new Equipo(VMequipo.NombreEquipo!, liga);
            equipo.Futbolistas = new List<Futbolista>();
            await _unidad.RepoEquipo.AltaAsync(equipo);
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
