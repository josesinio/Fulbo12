using System;
using System.Collections.Generic;
using System.Linq;

namespace Fulbo12.Core.Formacion
{
    public class Linea
    {
        public byte NumeroDeLinea { get; set; }
        public List<PosicionEnCancha> Posiciones { get; set; }
        public Linea() => Posiciones = new List<PosicionEnCancha>();
        public byte CantidadJugadores
        {
            get => Convert.ToByte(Posiciones.Count(item => item.Futbolista != null));
        }
        public byte QuimicaJugadores
        {
            get => Convert.ToByte(Posiciones.Sum(item => item.QuimicaJugador));
        }
    }
}