using Fulbo12.Core.Fixtures;

namespace Fulbo12.Core.Futbol.Fixtures
{
    public class LigasFixture
    {
        public Liga ProfFutbol { get; set; }
        public Liga Ligue1 { get; set; }
        public LigasFixture(PaisesFixtures paisesFixtures)
        {
            ProfFutbol = new Liga("Liga Profesional de Fútbol", paisesFixtures.Argentina);
            Ligue1 = new Liga("Ligue 1", paisesFixtures.Francia);
        }
    }
}