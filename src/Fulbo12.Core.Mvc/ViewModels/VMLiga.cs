using Fulbo12.Core.Futbol;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fulbo12.Core.Mvc.ViewModels
{
    public class VMLiga
    {
        public SelectList? Paises { get; set; }
        public string? NombreLiga {get; set;}
        public byte IdPais {get; set;}
        public byte IdLiga { get; set; }
        public VMLiga() { }
        public VMLiga(IEnumerable<Pais> paises)
        {
            Paises = new SelectList(paises,
                                    dataTextField: nameof(Pais.Nombre),
                                    dataValueField: nameof(Pais.Id));
        }
        public VMLiga(IEnumerable<Pais> paises, Liga liga)
        {
            Paises = new SelectList(paises,
                                    dataTextField: nameof(Pais.Nombre),
                                    dataValueField: nameof(Pais.Id),
                                    selectedValue: liga.Id);
            NombreLiga = liga.Nombre;
            IdLiga = liga.Id;
        }
    }
}