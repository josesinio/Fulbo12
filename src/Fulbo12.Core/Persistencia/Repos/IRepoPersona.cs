namespace Fulbo12.Core.Persistencia.Repos;
public interface IRepoPersona : IRepo<PersonaJuego>
{
    IEnumerable<PersonaJuego> BusquedaPersona(string? busqueda);
    Task<IEnumerable<PersonaJuego>> BusquedaPersonaAsync(string? busqueda);
}