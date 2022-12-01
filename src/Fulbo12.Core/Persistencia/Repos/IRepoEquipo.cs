using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.Repos;
public interface IRepoEquipo: IRepo<Equipo>
{
    public IEnumerable<Equipo> EquiposDe(Liga liga);
    public Task<IEnumerable<Equipo>> EquiposDeAsync(Liga liga);
    public bool ExisteNombreEnLiga(byte idLiga, string nombre);
    public Task<bool> ExisteNombreEnLigaAsync(byte idLiga, string nombre);
}