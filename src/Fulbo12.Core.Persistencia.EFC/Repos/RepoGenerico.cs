using System.Linq.Expressions;

namespace Fulbo12.Core.Persistencia.EFC.Repos;
public class RepoGenerico<T> : IRepo<T> where T: class
{
    Fulbo12Contexto _contexto;
    public RepoGenerico(Fulbo12Contexto contexto) => _contexto = contexto;
    public void Alta(T entidad) => _contexto.Set<T>().Add(entidad);
    public IEnumerable<T> Obtener(Expression<Func<T, bool>> filtro = null!, Func<IQueryable<T>, IOrderedQueryable<T>> orden = null!, string includes = null!)
    {
        throw new NotImplementedException();
    }
}