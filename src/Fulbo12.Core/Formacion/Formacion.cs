using System;
using System.Collections.Generic;
using System.Linq;

namespace Fulbo12.Core.Formacion
{
    public class Formacion
    {
        public List<Linea> Lineas { get; set; }
        public string Nombre { get; set; }
        public Formacion() => Lineas = new List<Linea>();
        public byte QuimicaJugadores
        {
            get => Convert.ToByte(Lineas.Sum(l => l.QuimicaJugadores));
        }
    }
}