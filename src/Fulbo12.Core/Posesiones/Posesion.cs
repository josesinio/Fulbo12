using System;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Posesiones
{
    public class Posesion
    {
        public static readonly byte MaximaCantidadDuenos = 199;
        public static readonly ushort MaximosPartidosGoles = 9999;
        public Usuario Usuario { get; set; }
        public Futbolista Futbolista { get; init; }
        public DateTime Adquisicion { get; private set; }
        public byte Duenos { get; private set; }
        public ushort Goles { get; private set; }
        public ushort PartidosJugados { get; private set; }
        public Posesion(Usuario usuario, Futbolista futbolista)
        {
            Usuario = usuario;
            Futbolista = futbolista;
            Duenos = 0;
            Reiniciar();
        }
        public Posesion(Usuario usuario, Futbolista futbolista, DateTime adquision,
                        byte duenos, ushort goles, ushort partidosJugados)
        {
            Usuario = usuario;
            Futbolista = futbolista;
            Adquisicion = adquision;
            Duenos = duenos;
            Goles = goles;
            PartidosJugados = partidosJugados;
        }
        public void Reiniciar()
        {
            Goles = PartidosJugados = 0;
            Adquisicion = DateTime.Today;
            Duenos++;
        }
        public void IncrementarPartido()
        {
            if (PartidosJugados < MaximosPartidosGoles)
                PartidosJugados++;
        }
        public void IncrementarGoles(byte goles)
            => Goles = (ushort)(Goles + goles >= MaximosPartidosGoles ?
                        MaximosPartidosGoles : Goles + goles);
        public void IncrementarDueno()
        {
            if (Duenos < MaximaCantidadDuenos)
                Duenos++;
        }
        public bool EsFutbolista(Futbolista futbolista)
            => Futbolista == futbolista;
    }
}