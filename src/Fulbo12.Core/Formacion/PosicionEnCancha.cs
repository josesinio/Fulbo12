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
        public bool EsNumero(byte numeroCamiseta)
            => NumeroCamiseta.HasValue && NumeroCamiseta == numeroCamiseta;
        public bool EsPersona(Persona persona)
            => Futbolista is not null && Futbolista.Persona == persona;
    }
}