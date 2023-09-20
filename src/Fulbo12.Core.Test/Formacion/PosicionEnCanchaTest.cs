using Fulbo12.Core.Formacion.Fixtures;
using Fulbo12.Core.Test.Formacion;

namespace Fulbo12.Core.Formacion.Test;
[Trait("Category", "Formacion")]
public class PosicionEnCanchaTest : IClassFixture<ClassFixtureFormacion>
{
    PosicionEnCanchaFixture PosicionesEnCancha { get; set; }
    public PosicionEnCanchaTest(ClassFixtureFormacion formacionFixture)
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
        Assert.True(PosicionesEnCancha.DFC.HayJugador);
    }

    [Fact]
    public void NoHayJugador()
    {
        Assert.False(PosicionesEnCancha.DFCVacante.HayJugador);
        Assert.False(PosicionesEnCancha.DFDVacante.HayJugador);
    }
}
