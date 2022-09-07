using System.ComponentModel.DataAnnotations;
using Fulbo12.Core;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fulbo12.Core.Mvc.ViewModels
{
    public class VMPersonaJuego
    {
        public SelectList? Paises { get; set; }
        public string? NombrePersona { get; set; }
        public string ApellidoPersona { get; set; }
        public float PesoPersona { get; set; }
        public float AlturaPersona { get; set; }
        public DateOnly NacimientoPersona { get; set; }
        [Range(1, byte.MaxValue, ErrorMessage = "Seleccione un pais por favor")]
        public byte IdPais {get; set;}
        public short IdPersona { get; set; }
        public VMPersonaJuego() { }
        public VMPersonaJuego(IEnumerable<Pais> paises)
        {
            Paises = new SelectList(paises,
                                    dataTextField: nameof(Pais.Nombre),
                                    dataValueField: nameof(Pais.Id));
        }
        public VMPersonaJuego(IEnumerable<Pais> paises, PersonaJuego persona)
        {
            Paises = new SelectList(paises,
                                    dataTextField: nameof(Pais.Nombre),
                                    dataValueField: nameof(Pais.Id),
                                    selectedValue: persona.Id);
            NombrePersona = persona.Nombre;
            ApellidoPersona = persona.Apellido;
            PesoPersona = persona.Peso;
            AlturaPersona = persona.Altura;
            NacimientoPersona = persona.Nacimiento;
            IdPersona = persona.Id;
        }
    }
}