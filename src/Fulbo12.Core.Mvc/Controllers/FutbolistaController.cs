using Fulbo12.Core.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace Fulbo12.Core.Mvc.Controllers;

public class FutbolistaController : Controller
{
    private readonly IUnidad _unidad;
    public FutbolistaController(IUnidad unidad) => _unidad = unidad;

    public async Task<IActionResult> Listado()
    {
        var futbolista = await _unidad.RepoFutbolista.ObtenerAsync();
        return View(futbolista);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error!");
    }
}