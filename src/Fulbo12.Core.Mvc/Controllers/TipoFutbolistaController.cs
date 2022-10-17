using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Fulbo12.Core.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Fulbo12.Core.Mvc.Controllers
{
    public class TipoFutbolistaController : Controller
    {
        private readonly IUnidad _unidad;
        public TipoFutbolistaController(IUnidad unidad) => _unidad = unidad;

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}