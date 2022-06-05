using Fulbo12.Core.Fixtures;

namespace Fulbo12.Core.Futbol.Fixtures;
public class FutbolFixture
{
    public EquiposFixture Equipos { get; set; }
    public FutbolistasFixture Futbolistas { get; set; }
    public LigasFixture Ligas { get; set; }
    public PosicionesFixture Posiciones { get; set; }
    public CoreFixture Core { get; set; }
    public FutbolFixture()
    {
        Core = new CoreFixture();
        Ligas = new LigasFixture(Core.Paises);
        Equipos = new EquiposFixture(Ligas);
        Posiciones = new PosicionesFixture();
        Futbolistas = new FutbolistasFixture(Core.Personas, Equipos, Posiciones);
    }
}