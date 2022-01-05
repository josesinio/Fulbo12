using System.Collections.Generic;
namespace Fulbo12.Core.Formacion
{
    public class Linea
    {
        public byte NumeroDeLinea { get; set; }
        public List<PosicionEnCancha> Posiciones { get; set; }
        public Linea() => Posiciones = new List<PosicionEnCancha>();

    }
}