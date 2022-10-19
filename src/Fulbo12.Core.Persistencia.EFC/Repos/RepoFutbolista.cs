using System.Linq.Expressions;
using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.EFC.Repos;

public class RepoFutbolista : RepoGenerico<Futbolista>, IRepoFutbolista
{
    public RepoFutbolista(Fulbo12Contexto contexto) : base(contexto) { }
    private IQueryable<Futbolista> PrepararConsultaAzar(Expression<Func<Futbolista, bool>> filtro, byte cantidad)
        => DbSet.Where(filtro)
            .Include(f => f.Equipo)
                .ThenInclude(e => e.Liga)
            .Include(f => f.Persona)
                .ThenInclude(p => p.Pais)
            .Take(cantidad)
            .OrderBy(f => EF.Functions.Random());
    public IEnumerable<Futbolista> ObtenerAlAzar(Expression<Func<Futbolista, bool>> filtro, byte cantidad)
        => PrepararConsultaAzar(filtro, cantidad)
            .ToList();

    public async Task<IEnumerable<Futbolista>> ObtenerAlAzarAsync(Expression<Func<Futbolista, bool>> filtro, byte cantidad)
        => await PrepararConsultaAzar(filtro, cantidad)
                    .ToListAsync();
}