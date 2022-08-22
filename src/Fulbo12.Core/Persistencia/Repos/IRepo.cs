using System.Linq.Expressions;

namespace Fulbo12.Core.Persistencia.Repos;
public interface IRepo<T> where T : class
{
    void Alta(T entidad);
    void Alta(IEnumerable<T> entidades);
    Task AltaAsync(T entidad);
    IEnumerable<T> Obtener(
        Expression<Func<T, bool>> filtro = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orden = null,
        string includes = null);
    Task<IEnumerable<T>> ObtenerAsync(
        Expression<Func<T, bool>> filtro = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orden = null,
        string includes = null);
}