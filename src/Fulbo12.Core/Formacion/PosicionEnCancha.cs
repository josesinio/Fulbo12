using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Formacion
{
    public class PosicionEnCancha
    {
        public Futbolista Futbolista { get; set; }
        public Posicion Posicion { get; set; }
        public byte? NumeroCamiseta { get; set; }
        public PosicionEnCancha() { }
        public PosicionEnCancha(Posicion posicion) => Posicion = posicion;
        public byte QuimicaJugador
        {
            get
            {
                if (HayJugador) return 0; else return 10;
            }
        }
        public bool HayJugador => Futbolista is not null;
        public bool EsPersona(Persona persona)
            => HayJugador && Futbolista.Persona == persona;
        public bool EsNumero(byte numCamiseta) => NumeroCamiseta.Equals(numCamiseta);
        public Persona Persona => Futbolista.Persona;
    }
}