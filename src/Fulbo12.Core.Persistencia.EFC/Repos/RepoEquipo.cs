using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.EFC.Repos;
public class RepoEquipo : RepoGenerico<Equipo>, IRepoEquipo
{
    public RepoEquipo(Fulbo12Contexto contexto) : base(contexto) { }

    public IEnumerable<Equipo> EquiposDe(Liga liga)
        => Obtener( filtro: e => e.Liga == liga,
                    orden: es => es.OrderBy(e => e.Nombre));

    public async Task<IEnumerable<Equipo>> EquiposDeAsync(Liga liga)
        => await ObtenerAsync(  filtro: e => e.Liga == liga,
                                orden: es => es.OrderBy(e => e.Nombre));
}
