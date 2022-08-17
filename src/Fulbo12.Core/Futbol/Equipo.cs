namespace Fulbo12.Core.Futbol;
public class Equipo
{
    public Liga Liga { get; set; }
    public string Nombre { get; set; }
    public short Id { get; set; }
    public List<Futbolista> Futbolistas { get; set; }
    public Equipo() => Futbolistas = new List<Futbolista>();
    public Equipo(string nombre, Liga liga) : this()
    {
        Nombre = nombre;
        Liga = liga;
    }
    public Equipo(string nombre, Liga liga, short id) : this(nombre, liga)
        => Id = id;

    public bool MismaLiga(Equipo equipo)
        => equipo.Liga == this.Liga;
    public void AgregarFutbolista(Futbolista futbolista)
    {
        futbolista.Equipo = this;
        Futbolistas.Add(futbolista);
    }
}