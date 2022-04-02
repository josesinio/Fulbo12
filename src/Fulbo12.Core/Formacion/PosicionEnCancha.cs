using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Formacion
{
    public class PosicionEnCancha
    {
        public Futbolista Futbolista { get; set; }
        public Posicion Posicion { get; set; }
        public byte? NumeroCamiseta { get; set; }
        public byte QuimicaJugador
        {
            get
            {
                if (HayJugador) return 0; else return 10;
            }
        }
        public bool HayJugador
        {
            get
            {
                if (Futbolista == null) return false; else return true;
            }
        }
    }
}