namespace Fulbo12.Core.Futbol;
public class Liga : ConNombre
{
    public List<Equipo> Equipos { get; set; }
    public Pais Pais { get; set; }
    public Liga() => Equipos = new List<Equipo>();
    public Liga(string nombre, Pais pais) : this(nombre)
    {
        Pais = pais;
        Equipos = new List<Equipo>();
    }

    public Liga(string nombre) : base(nombre) { }
}