using Fulbo12.Core.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Fulbo12.Core.Futbol;
using Fulbo12.Core.Persistencia.Excepciones;
using Fulbo12.Core.Mvc.ViewModels;

namespace Fulbo12.Core.Mvc.Controllers
{
    public class TipoFutbolistaController : Controller
    {
        private readonly IUnidad _unidad;
        public TipoFutbolistaController(IUnidad unidad) => _unidad = unidad;

        public async Task<IActionResult> Listado()
        {
            var tipoFutbolistas = await _unidad.RepoTipoFutbolista.ObtenerAsync
            (orden: ts => ts.OrderBy(t => t.Nombre));
            return View(tipoFutbolistas);
        }
        [HttpGet]
        public IActionResult Alta() => View("Upsert", new VMTipoFutbolista());
        [HttpGet]
        public async Task<IActionResult> Modificar(byte? id) 
        {
        if (id is null || id == 0)
            return NotFound();

        var tipoFutbolista = await _unidad.RepoTipoFutbolista.ObtenerPorIdAsync(id);
        if (tipoFutbolista is null)
            return NotFound();

        var vmTipoFutbolista = new VMTipoFutbolista(tipoFutbolista);
        return View("Upsert", vmTipoFutbolista);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(VMTipoFutbolista vmTipo)
        {
            if (!ModelState.IsValid)
                return View("Upsert", vmTipo);
            if (vmTipo.Id == 0)
            {
                await _unidad.RepoTipoFutbolista.AltaAsync(vmTipo.GenerarTipoFutbolista());
            }
            else
            {
                var tipoFRepo = await _unidad.RepoTipoFutbolista.ObtenerPorIdAsync(vmTipo.Id);
                if (tipoFRepo is null)
                    return NotFound();
                tipoFRepo.Nombre = vmTipo.Nombre;
                _unidad.RepoTipoFutbolista.Modificar(tipoFRepo);
            }
            try
            {
                await _unidad.GuardarAsync();
            }
            catch (EntidadDuplicadaException)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Listado));
        }

        [AcceptVerbs("GET", "POST")]
        public async Task<IActionResult> VerificarNombre(string nombre)
        {
            var resultado = await _unidad.RepoTipoFutbolista.ExisteNombreAsync(nombre);
            return resultado ? Json($"Ya existe {nombre} como Tipo de Futbolista") : Json(true);
        }
    }
}