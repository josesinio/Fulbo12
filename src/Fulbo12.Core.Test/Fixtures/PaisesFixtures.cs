namespace Fulbo12.Core.Fixtures;
public class PaisesFixtures
{
    private byte _id = 0;
    private byte _Id => ++_id;
    public Pais Argentina { get; set; }
    public Pais Colombia { get; set; }
    public Pais Francia { get; set; }
    public Pais Uruguay { get; set; }
    public Pais Paraguay { get; set; }
    public Pais Chile { get; set; }
    public PaisesFixtures()
    {
        Argentina = new Pais(_Id, "Argentina", "ar");
        Colombia = new Pais(_Id, "Colombia", "co");
        Francia = new Pais(_Id, "Francia", "fr");
        Uruguay = new Pais(_Id, "Uruguay", "uy");
        Paraguay = new Pais(_Id, "Paraguay", "py");
        Chile = new Pais(_Id, "Chile", "cl");
    }
}