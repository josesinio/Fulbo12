using Fulbo12.Core.Formacion.Fixtures;
using Xunit;

namespace Fulbo12.Core.Formacion.Test
{
    [Trait("Category", "Formacion")]
    public class FormacionTest: IClassFixture<FormacionFixture>
    {
        public Formacion Formacion { get; set; }
        static readonly string _nombre = "4 - 1 - 4 - 1";
        public FormacionTest(FormacionFixture fixture)
            => Formacion = fixture.CrearFormacion();

        [Fact]
        public void CadenaFormacion()
            => Assert.Equal(_nombre, Formacion.ToString());
        
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(9)]
        [InlineData(5)]
        public void ExisteNumero(byte numeroCamiseta) 
            => Assert.True(Formacion.ExisteNumero(numeroCamiseta));

        [Theory]
        [InlineData(0)]
        [InlineData(100)]
        public void NoExisteNumero(byte numeroCamiseta)
            => Assert.False(Formacion.ExisteNumero(numeroCamiseta));

        [Fact]
        public void NumeroDisponible()
        // Cuando se agregue arquero, hay que cambiar este 1
            => Assert.Equal(12, Formacion.NumeroDisponible);
    }
}