namespace Fulbo12.Core.Fixtures
{
    public class PaisesFixtures
    {
        public Pais Argentina { get; set; }
        public Pais Colombia { get; set; }
        public Pais Francia { get; set; }
        public PaisesFixtures()
        {
            Argentina = new Pais("Argentina");
            Colombia = new Pais("Colombia");
            Francia = new Pais("Francia");
        }
    }
}