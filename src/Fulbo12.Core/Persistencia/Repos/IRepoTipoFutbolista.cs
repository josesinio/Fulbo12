using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.Repos;
public interface IRepoTipoFutbolista : IRepo<TipoFutbolista>
{
    public bool ExisteNombre(string nombre);
    public Task<bool> ExisteNombreAsync(string nombre);
}