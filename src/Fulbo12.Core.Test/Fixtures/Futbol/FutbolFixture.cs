using Fulbo12.Core.Fixtures;

namespace Fulbo12.Core.Futbol.Fixtures;
public class FutbolFixture
{
    public EquiposFixture Equipos { get; set; }
    public FutbolistasFixture Futbolistas { get; set; }
    public LigasFixture Ligas { get; set; }
    public PosicionesFixture Posiciones { get; set; }
    public CoreFixture Core { get; set; }
    public TiposFutbolistasFixture TipoFutbolistas { get; set; }
    public FutbolFixture()
    {
        Core = new CoreFixture();
        Ligas = new LigasFixture(Core.Paises);
        Equipos = new EquiposFixture(Ligas);
        Posiciones = new PosicionesFixture();
        TipoFutbolistas = new TiposFutbolistasFixture();
        Futbolistas = new FutbolistasFixture(Core.Personas, Equipos, Posiciones, TipoFutbolistas);
        
    }
}