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
        public static readonly string _jugadorYaExiste = "Jugador ya existe en la formación";
        public static readonly string _posicionesLlenas = "No es posible agregar más jugadores en esta parte";

        public List<Linea> Lineas { get; set; }
        public List<Futbolista> Titulares { get; set; }
        public List<Futbolista> Suplentes { get; set; }
        public List<Futbolista> Reserva { get; set; }
        public PosicionEnCancha Arquero { get; set; }
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
            => Arquero.EsNumero(numeroCamiseta)
            || Lineas.Any(l => l.ExisteNumero(numeroCamiseta));
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
            => AgregarSiSePuedeEn(Suplentes, futbolista, CantidadSuplentes);
        public void AgregarReserva(Futbolista futbolista)
            => AgregarSiSePuedeEn(Reserva, futbolista, CantidadReserva);
        private void AgregarSiSePuedeEn(List<Futbolista> lista, Futbolista futbolista, byte tope)
        {
            if (lista.Count < tope)
            {
                if (ExistePersona(futbolista.Persona))
                    throw new InvalidOperationException(_jugadorYaExiste);
                lista.Add(futbolista);
            }
            else
                throw new InvalidOperationException(_posicionesLlenas);
        }
    }
}
