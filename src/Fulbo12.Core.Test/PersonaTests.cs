using Xunit;

namespace Fulbo12.Core.Test
{
    [Collection("ColeccionPersonasFutbolistas")]
    public class PersonaTests
    {
        FutbolistasFixture Fixture { get; set; }
        public PersonaTests(FutbolistasFixture fixture)
        {
            Fixture = fixture;
        }

        [Fact]
        public void InstanciaPersona()
        {
            Assert.Same(Fixture.Argentina, Fixture.PLioMessi.Pais);
            Assert.Equal("Lionel", Fixture.PLioMessi.Nombre);
            Assert.Equal("Messi", Fixture.PLioMessi.Apellido);
            Assert.Equal(1.7f, Fixture.PLioMessi.Altura, precision: 2);
        }

        [Fact]
        public void MismaNacionalidad()
        {
            Assert.False(Fixture.PLioMessi.MismaNacionalidad(Fixture.PFrankFabra));
            Assert.True(Fixture.PLioMessi.MismaNacionalidad(Fixture.PMarcosRojo));
        }
    }
}
