using System.ComponentModel.DataAnnotations;
using Fulbo12.Core.Futbol;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fulbo12.Core.Mvc.ViewModels
{
    public class VMEquipo
    {
        public SelectList? Ligas { get; set; }
        [Remote(action: "VerificarNombre", controller: "Equipo",
                AdditionalFields = nameof(IdLiga))]
        public string NombreEquipo { get; set; } = string.Empty;
        private byte LigaSelecionada => (byte)Ligas!.SelectedValue;
        [Range(1, byte.MaxValue, ErrorMessage = "Seleccione una liga por favor")]
        public byte IdLiga { get; set; }
        public short IdEquipo { get; set; }
        public VMEquipo() { }
        public VMEquipo(IEnumerable<Liga> ligas)
        {
            Ligas = new SelectList(ligas,
                                    dataTextField: nameof(Liga.Nombre),
                                    dataValueField: nameof(Liga.Id));
        }
        public VMEquipo(IEnumerable<Liga> ligas, Equipo equipo)
        {
            Ligas = new SelectList(ligas,
                                    dataTextField: nameof(Liga.Nombre),
                                    dataValueField: nameof(Liga.Id),
                                    selectedValue: equipo.Id);
            NombreEquipo = equipo.Nombre;
            IdEquipo = equipo.Id;
        }
    }
}