using Fulbo12.Core.Formacion.Fixtures;

namespace Fulbo12.Core.Test.Formacion;

public class ClassFixtureFormacion
{
    public FormacionFixture FormacionFixture { get; }
    public PosicionFormacionFixture PosicionFormacion { get; }
    public PosicionEnCanchaFixture PosicionesEnCancha { get; }
    public LineaFixture Lineas { get; }
    public ClassFixtureFormacion()
    {
        PosicionesEnCancha = new();
        var futbolFixture = PosicionesEnCancha.Futbol;
        PosicionFormacion = new(futbolFixture.Futbolistas);
        FormacionFixture = new FormacionFixture(futbolFixture);
        Lineas = new(PosicionesEnCancha);
    }
}
