using Fulbo12.Core;
using Fulbo12.Core.Mvc.ViewModels;
using Fulbo12.Core.Persistencia;
using Fulbo12.Core.Persistencia.Excepciones;
using Microsoft.AspNetCore.Mvc;

namespace Fulbo12.Core.Mvc.Controllers;

public class PersonaController : Controller
{
    private readonly IUnidad _unidad;

    public PersonaController(IUnidad unidad) => _unidad = unidad;

    public async Task<IActionResult> Listado()
    {
        var personas = await _unidad.RepoPersona.ObtenerAsync
                            (orden: ps => ps.OrderBy(p => p.Nombre));
        return View(personas);
    }
    public async Task<IActionResult> Detalle(short id)
    {
        var persona = await _unidad.RepoPersona.ObtenerPorIdAsync(id);
        return View(persona);
    }

    [HttpGet]
    public async Task<IActionResult> Alta()
    {
        var paises = await _unidad.RepoPais.ObtenerAsync
                        (orden: ps => ps.OrderBy(p => p.Nombre));
        var vmPersona = new VMPersonaJuego(paises);
        return View("Upsert", vmPersona);
    }

    [HttpGet]

    public async Task<IActionResult> Modificar(byte? id)
    {
        if (id is null || id == 0)
            return NotFound();

        var persona = await _unidad.RepoPersona.ObtenerPorIdAsync(id);
        if (persona is null)
            return NotFound();

        return View("Upsert", persona);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Upsert(PersonaJuego persona)
    {
        if (persona.Id == 0)
            await _unidad.RepoPersona.AltaAsync(persona);
        else
        {
            var personaRepo = await _unidad.RepoPersona.ObtenerPorIdAsync(persona.Id);
            if (personaRepo is null)
                return NotFound();
            personaRepo.Nombre = persona.Nombre;
            _unidad.RepoPersona.Modificar(personaRepo);
        }
        try
        {
            await _unidad.GuardarAsync();
        }
        catch (EntidadDuplicadaException e)
        {
            return NotFound();
        }
        return RedirectToAction(nameof(Listado));
    }
}