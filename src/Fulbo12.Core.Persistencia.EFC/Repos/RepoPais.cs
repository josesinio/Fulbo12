namespace Fulbo12.Core.Persistencia.EFC.Repos;
public class RepoPais : RepoGenerico<Pais>, IRepoPais
{
    public RepoPais(Fulbo12Contexto contexto) : base(contexto) { }
}