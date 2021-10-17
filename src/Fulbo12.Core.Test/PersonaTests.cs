using Xunit;

namespace Fulbo12.Core.Test
{
    public class PersonaTests
    {
        public Persona PepeArgento { get; set; }
        public Pais Argentina { get; set; }

        public PersonaTests()
        {
            Argentina = new Pais("Argentina");
            PepeArgento = new Persona()
            {
                Nombre = "Pepe",
                Apellido = "Argento",
                Pais = Argentina,
                Altura = 1.68f,
                Peso = 65
            };

        }
        [Fact]
        public void InstanciaPersona()
        {
            Assert.Same(Argentina, PepeArgento.Pais);
            Assert.Equal("Pepe", PepeArgento.Nombre);
            Assert.Equal("Argento", PepeArgento.Apellido);
            Assert.Equal(1.68f, PepeArgento.Altura, precision: 2);
        }
    }
}
