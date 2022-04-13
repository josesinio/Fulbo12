using System.Collections.Generic;
using Fulbo12.Core.Fixtures;

namespace Fulbo12.Core.Futbol.Fixtures
{
    public class FutbolistasFixture
    {
        public Futbolista FFrankFabra { get; set; }
        public Futbolista FLioMessi { get; private set; }
        public Futbolista FMarcosRojo { get; private set; }
        public Futbolista FEsequielBarco { get; private set; }
        public Futbolista FBrunoZuculini { get; private set; }
        public Futbolista FAgustinPalavecino { get; private set; }
        public Futbolista FJuanferQuintero { get; private set; }
        public Futbolista FNicoDeLaCruz { get; private set; }
        public Futbolista FEnzoFernandez { get; private set; }
        public Futbolista FEnzoPerez { get; private set; }
        public Futbolista FJoseParadela { get; private set; }
        public Futbolista FFelipePenaBiafore { get; private set; }
        public Futbolista FSantiagoSimon { get; private set; }
        public Futbolista FTomasPochettino { get; private set; }
        public Futbolista FBraianRomero { get; private set; }
        public Futbolista FFlabianLondono { get; private set; }
        public Futbolista FJulianAlvarez { get; private set; }
        public Futbolista FMatiasSuarez { get; private set; }
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

            FEsequielBarco = new Futbolista()
            {
                Persona = pef.PEsequielBarco,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FBrunoZuculini = new Futbolista()
            {
                Persona = pef.PBrunoZuculini,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FAgustinPalavecino = new Futbolista()
            {
                Persona = pef.PAgustinPalavecino,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FJuanferQuintero = new Futbolista()
            {
                Persona = pef.PJuanferQuintero,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FNicoDeLaCruz = new Futbolista()
            {
                Persona = pef.PNicoDeLaCruz,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FEnzoFernandez = new Futbolista()
            {
                Persona = pef.PEnzoFernandez,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FEnzoPerez = new Futbolista()
            {
                Persona = pef.PEnzoPerez,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FJoseParadela = new Futbolista()
            {
                Persona = pef.PJoseParadela,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FFelipePenaBiafore = new Futbolista()
            {
                Persona = pef.PFelipePenaBiafore,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FSantiagoSimon = new Futbolista()
            {
                Persona = pef.PSantiagoSimon,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FTomasPochettino = new Futbolista()
            {
                Persona = pef.PTomasPochettino,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediocampistaOfensivo}
            };

            FBraianRomero = new Futbolista()
            {
                Persona = pef.PBraianRomero,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediaPunta}
            };

            FFlabianLondono = new Futbolista()
            {
                Persona = pef.PFlabianLondono,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediaPunta}
            };

            FJulianAlvarez = new Futbolista()
            {
                Persona = pef.PJulianAlvarez,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediaPunta}
            };

            FMatiasSuarez = new Futbolista()
            {
                Persona = pef.PMatiasSuarez,
                Equipo = ef.RiverPlate,
                Posiciones = new List<Posicion>() {pof.MediaPunta}
            };
        }
    }
}