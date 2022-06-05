namespace Fulbo12.Core.Futbol;
public class Equipo
{
    public Liga Liga { get; set; }
    public string Nombre { get; set; }
    public Equipo() { }
    public Equipo(string nombre, Liga liga)
    {
        Nombre = nombre;
        Liga = liga;
    }

    public bool MismaLiga(Equipo equipo)
        => equipo.Liga == this.Liga;
}