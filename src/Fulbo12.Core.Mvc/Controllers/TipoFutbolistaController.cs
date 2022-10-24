using Fulbo12.Core.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Fulbo12.Core.Futbol;
using Fulbo12.Core.Persistencia.Excepciones;

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
        public IActionResult Alta() => View("Upsert");
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(TipoFutbolista tipoFutbolista)
        {
            if (tipoFutbolista.Id == 0)
            {
                await _unidad.RepoTipoFutbolista.AltaAsync(tipoFutbolista);
            }
            else
            {
                var tipoFRepo = await _unidad.RepoTipoFutbolista.ObtenerPorIdAsync(tipoFutbolista.Id);
                if (tipoFRepo is null)
                    return NotFound();
                tipoFRepo.Nombre = tipoFutbolista.Nombre;
                _unidad.RepoTipoFutbolista.Modificar(tipoFRepo);
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
}