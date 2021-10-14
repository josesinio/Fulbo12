using System;
namespace Fulbo12.Core
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Nacimiento { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public Pais Pais { get; set; }
    }
}