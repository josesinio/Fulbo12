namespace Fulbo12.Core.Futbol.Fixtures;

public class TiposFutbolistasFixture
{
    private byte _idTipo = 0;
    private byte _IdTipo => ++_idTipo;
    public TipoFutbolista OroComun { get; set; }
    public TipoFutbolista OroEspecial { get; set; }
    public TipoFutbolista Libertadores { get; set; }
    public TiposFutbolistasFixture()
    {
        OroComun = new(_IdTipo, "Oro común");
        OroEspecial = new(_IdTipo, "Oro Especial", especial: true);
        Libertadores = new(_IdTipo, "Libertadores", especial: true);
    }
}
