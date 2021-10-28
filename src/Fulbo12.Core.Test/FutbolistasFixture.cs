using System.Collections.Generic;
using Fulbo12.Core.Futbol;
using Xunit;

namespace Fulbo12.Core.Test
{
    public class FutbolistasFixture
    {
        #region Propiedades Fixture
        public Pais Argentina { get; set; }
        public Pais Colombia { get; set; }
        public Pais Francia { get; set; }
        public Liga ProfFutbol { get; set; }
        public Liga Ligue1 { get; set; }
        public Equipo BocaJrs { get; set; }
        public Equipo PSG { get; set; }
        public Persona PLioMessi { get; set; }
        public Persona PFrankFabra { get; set; }
        public Persona PMarcosRojo { get; set; }
        public Futbolista FFrankFabra { get; set; }
        public Futbolista FLioMessi { get; private set; }
        public Futbolista FMarcosRojo { get; private set; }
        public Posicion DefensorCentral { get; set; }
        public Posicion DefensorIzquierdo { get; set; }
        public Posicion MediaPunta { get; set; }
        public Posicion MediocampistaOfensivo { get; set; }
        #endregion
        public FutbolistasFixture()
        {
            SetupPaises();
            SetupLigas();
            SetupEquipos();
            SetupPersonas();
            SetupPosiciones();
            SetupFutbolistas();
        }

        private void SetupPaises()
        {
            Argentina = new Pais("Argentina");
            Colombia = new Pais("Colombia");
            Francia = new Pais("Francia");
        }
        private void SetupLigas()
        {
            ProfFutbol = new Liga("Liga Profesional de Fútbol", Argentina);
            Ligue1 = new Liga("Ligue 1", Francia);
        }
        private void SetupEquipos()
        {
            BocaJrs = new Equipo("Club Atlético Boca Juniors", ProfFutbol);
            PSG = new Equipo("Paris Saint-Germain Football Club", Ligue1);
        }
        private void SetupPersonas()
        {
            PLioMessi = new Persona()
            {
                Nombre = "Lionel",
                Apellido = "Messi",
                Pais = Argentina,
                Altura = 1.7f,
                Peso = 67
            };

            PFrankFabra = new Persona()
            {
                Nombre = "Frank",
                Apellido = "Fabra",
                Pais = Colombia,
                Altura = 1.74f,
                Peso = 80
            };

            PMarcosRojo = new Persona()
            {
                Nombre = "Marcos",
                Apellido = "Rojo",
                Pais = Argentina,
                Altura = 1.87f,
                Peso = 82
            };
        }
        private void SetupPosiciones()
        {
            DefensorIzquierdo = new Posicion()
            {
                Nombre = "Defensor Izquierdo"
            };

            DefensorCentral = new Posicion()
            {
                Nombre = "Defensor Central"
            };

            MediaPunta = new Posicion()
            {
                Nombre = "Media Punta"
            };

            MediocampistaOfensivo = new Posicion()
            {
                Nombre = "Mediocampista Ofensivo"
            };
        }
        private void SetupFutbolistas()
        {
            FLioMessi = new Futbolista()
            {
                Persona = PLioMessi,
                Equipo = PSG,
                Posiciones = new List<Posicion>() {MediaPunta, MediocampistaOfensivo}
            };

            FFrankFabra = new Futbolista()
            {
                Persona = PFrankFabra,
                Equipo = BocaJrs,
                Posiciones = new List<Posicion>() {DefensorCentral, DefensorIzquierdo}
            };

            FMarcosRojo = new Futbolista()
            {
                Persona = PMarcosRojo,
                Equipo = BocaJrs,
                Posiciones = new List<Posicion>() {DefensorCentral}
            };
        }
    }

    [CollectionDefinition("ColeccionPersonasFutbolistas")]
    public class ClaseColeccion : ICollectionFixture<FutbolistasFixture> { }
}