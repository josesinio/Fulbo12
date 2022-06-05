namespace Fulbo12.Core.Futbol;
public class Futbolista
{
    public Persona Persona { get; set; }
    public TipoFutbolista Tipofutbolista { get; set; }
    public Equipo Equipo { get; set; }
    public List<Posicion> Posiciones { get; set;}

    public bool MismaNacionalidad(Futbolista futbolista)
        => Persona.MismaNacionalidad(futbolista.Persona);

    public bool MismaLiga(Futbolista futbolista)
        => this.Equipo.MismaLiga(futbolista.Equipo);
    
    public bool MismoEquipo(Futbolista futbolista)
        => futbolista.Equipo == this.Equipo;
    
    public bool JuegaDe(Posicion posicion)
        => Posiciones.Contains(posicion);

    public Futbolista()
    {
        Posiciones = new List<Posicion>();
    }
}