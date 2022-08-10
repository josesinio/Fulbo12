using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.EFC.Repos;
public class RepoEquipo : RepoGenerico<Equipo>, IRepoEquipo
{
    public RepoEquipo(Fulbo12Contexto contexto) : base(contexto) { }
}
