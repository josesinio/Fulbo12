namespace Fulbo12.Core.Futbol.Fixtures
{
    public class EquiposFixture
    {
        public Equipo BocaJrs { get; set; }
        public Equipo PSG { get; set; }
        public EquiposFixture(LigasFixture ligasFixture)
        {
            BocaJrs = new Equipo("Club Atlético Boca Juniors", ligasFixture.ProfFutbol);
            PSG = new Equipo("Paris Saint-Germain Football Club", ligasFixture.Ligue1);
        }
    }
}