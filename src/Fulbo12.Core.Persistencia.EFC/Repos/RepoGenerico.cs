using System.Linq.Expressions;

namespace Fulbo12.Core.Persistencia.EFC.Repos;
public abstract class RepoGenerico<T> : IRepo<T> where T : class
{
    Fulbo12Contexto _contexto;
    public RepoGenerico(Fulbo12Contexto contexto) => _contexto = contexto;
    public void Alta(T entidad) => _contexto.Set<T>().AddRange(entidad);
    public void Alta(IEnumerable<T> entidades) => _contexto.Set<T>().AddRange(entidades);
    public async Task AltaAsync(T entidad)
        => await _contexto.Set<T>().AddRangeAsync(entidad);
    public IEnumerable<T> Obtener(Expression<Func<T, bool>> filtro = null!, Func<IQueryable<T>, IOrderedQueryable<T>> orden = null!, string includes = null!)
    {
        throw new NotImplementedException();
    }
}