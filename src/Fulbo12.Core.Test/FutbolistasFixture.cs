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
        #endregion
        public FutbolistasFixture()
        {
            Argentina = new Pais("Argentina");
            Colombia = new Pais("Colombia");
            Francia = new Pais("Francia");

            ProfFutbol = new Liga("Liga Profesional de Fútbol", Argentina);
            Ligue1 = new Liga("Ligue 1", Francia);

            BocaJrs = new Equipo("Club Atlético Boca Juniors", ProfFutbol);
            PSG = new Equipo("Paris Saint-Germain Football Club", Ligue1);

            PLioMessi = new Persona()
            {
                Nombre = "Lionel",
                Apellido = "Messi",
                Pais = Argentina,
                Altura = 1.7f,
                Peso = 67
            };
            FLioMessi = new Futbolista()
            {
                Persona = PLioMessi,
                Equipo = PSG
            };

            PFrankFabra = new Persona()
            {
                Nombre = "Frank",
                Apellido = "Fabra",
                Pais = Colombia,
                Altura = 1.74f,
                Peso = 80
            };
            FFrankFabra = new Futbolista()
            {
                Persona = PFrankFabra,
                Equipo = BocaJrs
            };

            PMarcosRojo = new Persona()
            {
                Nombre = "Marcos",
                Apellido = "Rojo",
                Pais = Argentina,
                Altura = 1.87f,
                Peso = 82
            };
            FMarcosRojo = new Futbolista()
            {
                Persona = PMarcosRojo,
                Equipo = BocaJrs
            };
        }
    }

    [CollectionDefinition("ColeccionPersonasFutbolistas")]
    public class ClaseColeccion : ICollectionFixture<FutbolistasFixture> { }
}