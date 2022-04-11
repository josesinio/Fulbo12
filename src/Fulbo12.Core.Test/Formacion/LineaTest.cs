using Fulbo12.Core.Formacion.Fixtures;
using Xunit;

namespace Fulbo12.Core.Formacion.Test
{
    public class LineaTest : IClassFixture<FormacionFixture>
    {
        static readonly byte _NroInexistente = 250;
        static readonly byte _CantidadJugadoresDefensa = 2;
        static readonly byte _CantidadPosicionesDefensa = 4;
        public LineaFixture Lineas { get; set; }
        public LineaTest(FormacionFixture formacion)
        {
            Lineas = formacion.Lineas;
        }

        [Theory]
        [InlineData(PosicionEnCanchaFixture.NroFabra)]
        [InlineData(PosicionEnCanchaFixture.nroRojo)]
        public void ExisteNumero(byte nro)
            => Assert.True(Lineas.Defensas.ExisteNumero(nro));

        [Fact]
        public void NoExistenNumero()
            => Assert.False(Lineas.Defensas.ExisteNumero(_NroInexistente));

        [Fact]
        public void CantidadJugadoresDefensa()
            => Assert.Equal(_CantidadJugadoresDefensa, Lineas.Defensas.CantidadJugadores);

        [Fact]
        public void CantidadPosicionesDefensa()
            => Assert.Equal(_CantidadPosicionesDefensa, Lineas.Defensas.CantidadPosiciones);
    }
}