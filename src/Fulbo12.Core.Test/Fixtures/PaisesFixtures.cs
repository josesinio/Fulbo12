namespace Fulbo12.Core.Fixtures
{
    public class PaisesFixtures
    {
        public Pais Argentina { get; set; }
        public Pais Colombia { get; set; }
        public Pais Francia { get; set; }
        public Pais Uruguay { get; set; }
        public Pais Paraguay { get; set; }
        public Pais Chile { get; set; }
        public PaisesFixtures()
        {
            Argentina = new Pais("Argentina");
            Colombia = new Pais("Colombia");
            Francia = new Pais("Francia");
            Uruguay = new Pais("Uruguay");
            Paraguay = new Pais("Paraguay");
            Chile = new Pais("Chile");
        }
    }
}