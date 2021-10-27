using System.Collections.Generic;

namespace Fulbo12.Core.Futbol
{
    public class Futbolista
    {
        public Persona Persona { get; set; }
        public TipoFutbolista Tipofutbolista { get; set; }
        public Equipo Equipo { get; set; }
        public List<Posicion> Pociciones { get; set;}

        public bool MismaNacionalidad(Futbolista futbolista)
            => Persona.MismaNacionalidad(futbolista.Persona);

        public bool MismaLiga(Futbolista futbolista)
            => this.Equipo.MismaLiga(futbolista.Equipo);
        
        public bool MismoEquipo(Futbolista futbolista)
            => futbolista.Equipo == this.Equipo; 
        
        public bool JuegaDe(Posicion posicion)
            => Pociciones.Contains(posicion);
        
        public Futbolista()
        {
            Pociciones = new List<Posicion>();
        }
    }
}