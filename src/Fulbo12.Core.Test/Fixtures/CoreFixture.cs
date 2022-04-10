namespace Fulbo12.Core.Fixtures
{
    public class CoreFixture
    {
        public PaisesFixtures Paises { get; set; }
        public PersonasFixture Personas { get; set; }        
        public CoreFixture()
        {
            Paises = new PaisesFixtures();
            Personas = new PersonasFixture(Paises);
        }
    }
}