using Fulbo12.Core.Persistencia.EFC.Repos;
using Fulbo12.Core.Persistencia.Excepciones;

namespace Fulbo12.Core.Persistencia.EFC;
public class Unidad : IUnidad
{
    public IRepoPais RepoPais => repoPais;
    public IRepoPersona RepoPersona => repoPersona;
    public IRepoLiga RepoLiga => repoLiga;

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
    public void Guardar()
    {
        try
        {
            Contexto.SaveChanges();
        }
        catch (System.Exception e)
        {
            throw new EntidadDuplicadaException("bla", e);
        }
    }
    public async Task GuardarAsync()
    {
        try
        {
            await Contexto.SaveChangesAsync();
        }
        catch (System.Exception e)
        {
            throw new EntidadDuplicadaException("bla", e);
        }
    }
    
}
