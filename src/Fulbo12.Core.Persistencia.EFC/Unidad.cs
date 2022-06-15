using Fulbo12.Core.Persistencia.EFC.Repos;

namespace Fulbo12.Core.Persistencia.EFC;
public class Unidad : IUnidad
{
    public IRepoPais RepoPais => repoPais;
    public IRepoPersona RepoPersona => repoPersona;
    public IRepoLiga RepoLiga => RepoLiga;

    RepoPais repoPais;
    RepoPersona repoPersona;
    RepoLiga repoLiga;
    private readonly Fulbo12Contexto Contexto;
    public Unidad(Fulbo12Contexto contexto)
    {
        Contexto = contexto;
        repoPais = new RepoPais(contexto);
        repoPersona = new RepoPersona(contexto);
        repoLiga = new RepoLiga(contexto);
    }
    public void Guardar() => Contexto.SaveChanges();
    public async Task GuardarAsync()
        => await Contexto.SaveChangesAsync();
}
