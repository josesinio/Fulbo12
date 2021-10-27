using System.Collections.Generic;
namespace Fulbo12.Core.Futbol
{
    public class Liga
    {
        public string Nombre { get; set; }
        public List<Equipo> Equipos { get; set; }
        public Pais Pais { get; set; }
        public Liga() { }
        public Liga(string nombre, Pais pais)
        {
            Nombre = nombre;
            Pais = pais;
        }
    }
}