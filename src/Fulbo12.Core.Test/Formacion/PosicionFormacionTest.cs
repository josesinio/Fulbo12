using System.Drawing;
using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Test.Formacion;
[Trait("Category", "Formacion")]
public class PosicionFormacionTest : IClassFixture<FutbolistasFixture>
{
    FutbolistasFixture Futbolista { get; set; }

    public PosicionFormacionTest(FutbolistasFixture fubolistas)
    => Futbolista = fubolistas;

    [Fact]
    public void PuntosMedios()
    {
        var pmMR442 = new PointF(FutbolistasFixture..SuperiorX, PosicionFormacion.DfcMR442.SuperiorY);

        var PM = new PointF(PosicionFormacion.DfcMR433.SuperiorX, PosicionFormacion.DfcMR433.SuperiorY);

        Assert.Equal(pmMR442, PM);


    }
}