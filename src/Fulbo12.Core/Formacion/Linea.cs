using System.Collections.Generic;

namespace Fulbo12.Core.Formacion
{
    public class Linea
    {
        public byte NumeroDeLinea { get; set; }
        public List<PosicionEnCancha> Posiciones { get; set; }
        public Linea() => Posiciones = new List<PosicionEnCancha>();
        public byte CantidadJugadores
        {
            get
            {
                byte jugadores = 0;
                foreach (var item in Posiciones)
                {
                    if (item.Jugador != null)
                    jugadores++;
                }
                return jugadores;
            }
        }
        public byte QuimicaJugadores
        {
            get
            {
                byte suma = 0;
                foreach (var item in Posiciones)
                {
                    suma += item.QuimicaJugador;
                }
                return suma;
            }
        }
    }
}