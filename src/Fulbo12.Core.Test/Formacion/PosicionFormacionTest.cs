using System.Drawing;
using Fulbo12.Core.Formacion.Fixtures;
namespace Fulbo12.Core.Test.Formacion;
[Trait("Category", "Formacion")]
public class PosicionFormacionTest : IClassFixture<PosicionFormacionFixture>
{
    PosicionFormacionFixture PosicionFormacion { get; set; }
    public PosicionFormacionTest(FormacionFixture formacionFixture)
    => PosicionFormacion = formacionFixture.PosicionFormacion;

    
    [Fact]
    public void PuntosMedios()
    {
        var pmMR442 = new PointF(PosicionFormacion.DfcMR442.SuperiorX, PosicionFormacion.DfcMR442.SuperiorY);

        var PM = new PointF()
        // var pmMR433 = new PointF(PosicionFormacion.DfcMR433.SuperiorX, PosicionFormacion.DfcMR433.SuperiorY);

    }
}