namespace Fulbo12.Core.Futbol;
public class Liga : ConNombre
{
    public List<Equipo> Equipos { get; set; }
    public Pais Pais { get; set; }
    public Liga(string nombre, Pais pais) : base(nombre)
        => Pais = pais;
    public Liga(string nombre) : base(nombre) {}
        
}