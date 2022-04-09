using System.Collections.Generic;
using Fulbo12.Core.Fixtures;

namespace Fulbo12.Core.Futbol.Fixtures
{
    public class FutbolistasFixture
    {
        public Futbolista FFrankFabra { get; set; }
        public Futbolista FLioMessi { get; private set; }
        public Futbolista FMarcosRojo { get; private set; }
        public FutbolistasFixture(PersonasFixture pef, EquiposFixture ef, PosicionesFixture pof)
        {
            FLioMessi = new Futbolista()
            {
                Persona = pef.PLioMessi,
                Equipo = ef.PSG,
                Posiciones = new List<Posicion>() {pof.MediaPunta, pof.MediocampistaOfensivo}
            };

            FFrankFabra = new Futbolista()
            {
                Persona = pef.PFrankFabra,
                Equipo = ef.BocaJrs,
                Posiciones = new List<Posicion>() {pof.DefensorCentral, pof.DefensorIzquierdo}
            };

            FMarcosRojo = new Futbolista()
            {
                Persona = pef.PMarcosRojo,
                Equipo = ef.BocaJrs,
                Posiciones = new List<Posicion>() {pof.DefensorCentral}
            };
        }
    }
}