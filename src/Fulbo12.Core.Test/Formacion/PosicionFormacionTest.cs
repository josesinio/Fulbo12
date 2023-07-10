using Fulbo12.Core.Formacion.Fixtures;
namespace Fulbo12.Core.Test.Formacion;
[Trait("Category", "Formacion")]
public class PosicionFormacionTest : IClassFixture<PosicionFormacionFixture>
{
    PosicionFormacionFixture PosicionFormacion { get; set; }
    public PosicionFormacionTest(FormacionFixture formacionFixture)
    => PosicionFormacion = formacionFixture.PosicionFormacion;

    [Theory]
    [InlineData()]
    public void Test1()
    {
        Assert.True(true);
    }
}