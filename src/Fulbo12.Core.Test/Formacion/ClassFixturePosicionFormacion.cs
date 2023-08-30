using Fulbo12.Core.Formacion.Fixtures;

namespace Fulbo12.Core.Test.Formacion;
public class ClassFixturePosicionFormacion
{
    public PosicionFormacionFixture PosicionFormacionFixture { get;}
    public ClassFixturePosicionFormacion()  => PosicionFormacionFixture = new();
}
