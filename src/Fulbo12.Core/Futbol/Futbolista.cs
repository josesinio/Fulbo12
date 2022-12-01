namespace Fulbo12.Core.Futbol;
public class Futbolista
{
    public ushort Id { get; set; }
    public required PersonaJuego Persona { get; set; }
    public required TipoFutbolista Tipofutbolista { get; set; }
    public required Equipo Equipo { get; set; }
    public List<Posicion> Posiciones { get; set; }
    public byte Valoracion { get; set; }

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