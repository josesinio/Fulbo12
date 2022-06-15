using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Persistencia.EFC.Repos;
public class RepoLiga : RepoGenerico<Liga>, IRepoLiga
{
    public RepoLiga(Fulbo12Contexto contexto) : base(contexto) { }
}