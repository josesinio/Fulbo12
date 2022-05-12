using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Formacion
{
    public class Formacion
    {
        public static readonly byte CantidadTitulares = 11;
        public static readonly byte CantidadSuplentes = 5;
        public static readonly byte CantidadReserva = 5;
        public static readonly byte CantidadTotalJugadores =
            Convert.ToByte(CantidadTitulares + CantidadSuplentes + CantidadReserva);
        public List<Linea> Lineas { get; set; }
        public List<Futbolista> Titulares { get; set; }
        public List<Futbolista> Suplentes { get; set; }
        public List<Futbolista> Reserva { get; set; }
        public Formacion()
        {
            Lineas = new List<Linea>();
            Titulares = new();
            Suplentes = new();
            Reserva = new();
        }
        public byte QuimicaJugadores
            => Convert.ToByte(Lineas.Sum(l => l.QuimicaJugadores));
        private IEnumerable<byte> PosicionesPorLinea
            => Lineas.Select(l => l.CantidadPosiciones);
        public override string ToString()
            => new StringBuilder().AppendJoin(" - ", PosicionesPorLinea).ToString();
        public bool ExisteNumero(byte numeroCamiseta)
            => Lineas.Any(l => l.ExisteNumero(numeroCamiseta));
        public byte NumeroDisponible
        {
            get
            {
                for (byte i = 1; i < CantidadTotalJugadores; i++)
                {
                    if (!ExisteNumero(i))
                        return i;
                }
                throw new InvalidOperationException("No hay más dorsales disponibles");
            }
        }
        public bool ExistePersona(Persona persona)
            => Lineas.Any(l => l.ExistePersona(persona));
        public void AgregarSuplente(Futbolista futbolista)
        {
            if (Suplentes.Count < CantidadSuplentes)
            {
                if (ExistePersona(futbolista.Persona))
                    throw new InvalidOperationException("Ya existe un jugador con esa persona");
                Suplentes.Add(futbolista);
            }
            else
            {
                throw new InvalidOperationException("No hay más espacio para suplentes");
            }
        }
        public void AgregarReserva(Futbolista futbolista)
        {
            if (Reserva.Count < CantidadReserva)
            {
                if (ExistePersona(futbolista.Persona))
                    throw new InvalidOperationException("Ya existe este jugador en la formacion");
                Reserva.Add(futbolista);
            }
            else
            {
                throw new InvalidOperationException("No hay más espacio para reservas");
            }
        }
    }
}
