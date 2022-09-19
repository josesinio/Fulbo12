using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.EFC.Repos;

public class RepoFutbolista : RepoGenerico<Futbolista>, IRepoFutbolista
{
    public RepoFutbolista(Fulbo12Contexto contexto) : base(contexto) { }
    
}