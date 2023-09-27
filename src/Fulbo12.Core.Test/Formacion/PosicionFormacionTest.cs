using System.Drawing;
using Fulbo12.Core.Formacion.Fixtures;

namespace Fulbo12.Core.Test.Formacion;
[Trait("Category", "Formacion")]
public class PosicionFormacionTest : IClassFixture<ClassFixtureFormacion>
{
    PosicionFormacionFixture pff { get; set; }


    public PosicionFormacionTest(ClassFixtureFormacion posicionFormacion)
    => pff = posicionFormacion.PosicionFormacion;

    [Fact]
    public void PuntosMedios()
    {
        var pmMR442 = new PointF(pff.DfcMR442.SuperiorX, pff.DfcMR442.SuperiorY);
        var PM = new PointF(pff.DfcMR433.SuperiorX, pff.DfcMR433.SuperiorX);

        Assert.Equal(pmMR442, PM);
    }

    [Fact]
    public void PuntoNoMedio()
    {
        var puntoMedioEF = new PointF(pff.MCEF433.SuperiorX, pff.MCEF433.SuperiorY);
        var puntoMedioMR = new PointF(pff.DfcMR442.SuperiorX, pff.DfcMR442.SuperiorY);

        Assert.NotEqual(puntoMedioEF, puntoMedioMR);
    }
    [Theory]
    [InlineData(110f, 18.75f, false)]
    [InlineData(37.5f, 27.5f, true)]
    [InlineData(3566f, 51689f, false)]
    public void TieneAMedio(float x, float y, bool respuestas)
    => Assert.Equal(respuestas , pff.DfcMR433.TieneA(x, y));

}