using Fulbo12.Core.Fixtures;
using Xunit;

namespace Fulbo12.Core.Test
{
    public class PersonaTests : IClassFixture<CoreFixture>
    {
        CoreFixture f { get; set; }

        public PersonaTests(CoreFixture coreFixture) => f = coreFixture;

        [Fact]
        public void InstanciaPersona()
        {
            Assert.Same(f.Paises.Argentina, f.Personas.PLioMessi.Pais);
            Assert.Equal("Lionel", f.Personas.PLioMessi.Nombre);
            Assert.Equal("Messi", f.Personas.PLioMessi.Apellido);
            Assert.Equal(1.7f, f.Personas.PLioMessi.Altura, precision: 2);
        }

        [Fact]
        public void MismaNacionalidad()
        {
            Assert.False(f.Personas.PLioMessi.MismaNacionalidad(f.Personas.PFrankFabra));
            Assert.True(f.Personas.PLioMessi.MismaNacionalidad(f.Personas.PMarcosRojo));
        }
    }
}