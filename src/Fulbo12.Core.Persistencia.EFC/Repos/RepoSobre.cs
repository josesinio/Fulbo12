using Fulbo12.Core.Sobres;

namespace Fulbo12.Core.Persistencia.EFC.Repos;
public class RepoSobre : RepoGenerico<Sobre>, IRepoSobre
{
    public RepoSobre(Fulbo12Contexto contexto) : base(contexto) { }
}
