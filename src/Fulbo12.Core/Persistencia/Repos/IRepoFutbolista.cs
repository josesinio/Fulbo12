using System.Linq.Expressions;
using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.Repos;
public interface IRepoFutbolista : IRepo<Futbolista>
{
    public IEnumerable<Futbolista> ObtenerAlAzar(Expression<Func<Futbolista, bool>> filtro, byte cantidad);
    public Task<IEnumerable<Futbolista>> ObtenerAlAzarAsync(Expression<Func<Futbolista, bool>> filtro, byte cantidad);
}