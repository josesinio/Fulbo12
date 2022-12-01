using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Persistencia.EFC.Repos;
public class RepoLiga : RepoGenerico<Liga>, IRepoLiga
{
    public RepoLiga(Fulbo12Contexto contexto) : base(contexto) { }

    public IEnumerable<Liga> LigasDe(Pais pais)
        => Obtener( filtro: l => l.Pais == pais,
                    orden: ls => ls.OrderBy(l => l.Nombre));

    public async Task<IEnumerable<Liga>> LigasDeAsync(Pais pais)
        => await ObtenerAsync(  filtro: l => l.Pais == pais,
                                orden: ls => ls.OrderBy(l => l.Nombre));
}