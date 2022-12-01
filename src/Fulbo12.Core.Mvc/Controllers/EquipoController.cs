using Microsoft.AspNetCore.Mvc;
using Fulbo12.Core.Mvc.ViewModels;
using Fulbo12.Core.Persistencia;
using Fulbo12.Core.Futbol;
using Fulbo12.Core.Persistencia.Excepciones;

namespace Fulbo12.Core.Mvc.Controllers;

public class EquipoController : Controller
{
    private readonly IUnidad _unidad;
    public EquipoController(IUnidad unidad) => _unidad = unidad;

    public async Task<IActionResult> Listado()
    {
        var equipos = await _unidad.RepoEquipo.ObtenerAsync
            (orden: es => es.OrderBy(e => e.Nombre),
            includes: "Liga");
        return View(equipos);
    }
    [HttpGet]
    public async Task<IActionResult> Detalle(short? id)
    {
        if (id is null || id == 0)
            return NotFound();

        var equipo = await _unidad.RepoEquipo.ObtenerAsync(filtro: es => es.Id == id,
            includes: "Liga,Futbolistas");

        if (equipo is null)
            return NotFound();

        return View("Detalle", equipo.First());
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
            var equipo = new Equipo(VMequipo.NombreEquipo!, liga!);
            equipo.Futbolistas = new List<Futbolista>();
            await _unidad.RepoEquipo.AltaAsync(equipo);
        }

        try
        {
            await _unidad.GuardarAsync();
        }
        catch (EntidadDuplicadaException)
        {
            return NotFound();
        }

        return RedirectToAction(nameof(Index));
    }

    [AcceptVerbs("GET", "POST")]
    public async Task<IActionResult> VerificarNombre(string nombreEquipo, byte idLiga)
    {
        var resultado = await _unidad.RepoEquipo.ExisteNombreEnLigaAsync(idLiga, nombreEquipo);
        return resultado ? Json($"Ya existe {nombreEquipo} en esa liga") : Json(true);
    }
}
