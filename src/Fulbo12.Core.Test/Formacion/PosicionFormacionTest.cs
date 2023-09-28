using System.Drawing;
using Fulbo12.Core.Formacion.Fixtures;

namespace Fulbo12.Core.Test.Formacion;
[Trait("Category", "Formacion")]
public class PosicionFormacionTest : IClassFixture<ClassFixtureFormacion>
{
    PosicionFormacionFixture Pff { get; set; }


    public PosicionFormacionTest(ClassFixtureFormacion posicionFormacion)
    => Pff = posicionFormacion.PosicionFormacion;

    [Fact]
    public void PuntosMedios()
    {
        var pmMR442 = new PointF(Pff.DfcMR442.SuperiorX, Pff.DfcMR442.SuperiorY);
        var PM = new PointF(Pff.DfcMR433.SuperiorX, Pff.DfcMR433.SuperiorY);

        Assert.Equal(pmMR442, PM);
    }

    [Fact]
    public void PuntoNoMedio()
    {
        var puntoMedioEF = new PointF(Pff.MCEF433.SuperiorX, Pff.MCEF433.SuperiorY);
        var puntoMedioMR = new PointF(Pff.DfcMR442.SuperiorX, Pff.DfcMR442.SuperiorY);

        Assert.NotEqual(puntoMedioEF, puntoMedioMR);
    }
    [Theory]
    [InlineData(110f, 18.75f, false)]
    [InlineData(37.5f, 27.5f, true)]
    [InlineData(3566f, 51689f, false)]
    public void TieneAMedio(float x, float y, bool respuestas)
    => Assert.Equal(respuestas, Pff.DfcMR433.TieneA(x, y));

    [Fact]
    public void TieneAMP()
    {
        var punto433 = new PointF(Pff.DfcMR433.SuperiorX, Pff.DfcMR433.SuperiorY);
        Assert.True(Pff.DfcMR433.TieneA(punto433));
    }

    [Fact]
    public void NoTieneAMP()
    {
        var punto433 = new PointF(Pff.DfcMR433.SuperiorX, Pff.DfcMR433.SuperiorY);
        Assert.False(Pff.MCEF433.TieneA(punto433));
    }
}