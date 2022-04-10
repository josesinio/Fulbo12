using Fulbo12.Core.Formacion.Fixtures;
using Xunit;

namespace Fulbo12.Core.Formacion.Test
{
    public class PosicionEnCanchaTest : IClassFixture<FormacionFixture>
    {
        PosicionEnCanchaFixture PosicionesEnCancha { get; set; }
        public PosicionEnCanchaTest(FormacionFixture formacionFixture)
            => PosicionesEnCancha = formacionFixture.PosicionesEnCancha;

        [Theory]
        [InlineData(3, true)]
        [InlineData(5, false)]
        public void EsNumero(byte nroCamiseta, bool respuesta)
            => Assert.Equal(respuesta, PosicionesEnCancha.DFI.EsNumero(nroCamiseta));

        [Fact]
        public void HayJugador()
        {
            Assert.True(PosicionesEnCancha.DFI.HayJugador);
        }
    }
}
