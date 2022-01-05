using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Formacion
{
    public class PosicionEnCancha
    {
        public Futbolista Jugador { get; set; }
        public Posicion Posicion { get; set; }
        public byte? NumeroCamiseta { get; set; }
        public byte QuimicaJugador { get; }
    }
}