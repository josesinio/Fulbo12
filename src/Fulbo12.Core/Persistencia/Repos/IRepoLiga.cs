using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Persistencia.Repos;
public interface IRepoLiga: IRepo<Liga>
{
    public IEnumerable<Liga> LigasDe(Pais pais);
    public Task<IEnumerable<Liga>> LigasDeAsync(Pais pais);
}