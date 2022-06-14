namespace Fulbo12.Core.Persistencia.EFC.Repos;
public class RepoPersona : RepoGenerico<Persona>, IRepoPersona
{
    public RepoPersona(Fulbo12Contexto contexto) : base(contexto) { }
}