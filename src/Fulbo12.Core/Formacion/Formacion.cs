using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fulbo12.Core.Formacion
{
    public class Formacion
    {
        public List<Linea> Lineas { get; set; }
        public Formacion() => Lineas = new List<Linea>();
        public byte QuimicaJugadores
            => Convert.ToByte(Lineas.Sum(l => l.QuimicaJugadores));
        private IEnumerable<byte> PosicionesPorLinea
            => Lineas.Select(l => l.CantidadPosiciones);
        public override string ToString()
            => new StringBuilder().AppendJoin(" - ", PosicionesPorLinea).ToString();
    }
}