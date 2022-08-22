using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Fulbo12.Core.Mvc.Views.Pais
{
    public class Upsert : PageModel
    {
        private readonly ILogger<Upsert> _logger;

        public Upsert(ILogger<Upsert> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}