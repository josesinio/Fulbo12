namespace Fulbo12.Core.Fixtures;
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
        Argentina = new Pais("Argentina", "ar");
        Colombia = new Pais("Colombia", "co");
        Francia = new Pais("Francia", "fr");
        Uruguay = new Pais("Uruguay", "uy");
        Paraguay = new Pais("Paraguay", "py");
        Chile = new Pais("Chile", "cl");
    }
}