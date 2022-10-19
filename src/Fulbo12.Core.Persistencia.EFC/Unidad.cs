using Fulbo12.Core.Persistencia.EFC.Repos;
using Fulbo12.Core.Persistencia.Excepciones;

namespace Fulbo12.Core.Persistencia.EFC;
public class Unidad : IUnidad
{
    public IRepoPais RepoPais => _repoPais;
    public IRepoPersona RepoPersona => _repoPersona;
    public IRepoLiga RepoLiga => _repoLiga;
    public IRepoEquipo RepoEquipo => _repoEquipo;
    public IRepoFutbolista RepoFutbolista => _repoFutbolista;

    public IRepoSobre RepoSobre => _repoSobre;

    RepoPais _repoPais;
    RepoPersona _repoPersona;
    RepoLiga _repoLiga;
    RepoEquipo _repoEquipo;
    RepoFutbolista _repoFutbolista;
    RepoSobre _repoSobre;
    private readonly Fulbo12Contexto Contexto;
    public Unidad(Fulbo12Contexto contexto)
    {
        Contexto = contexto;
        _repoPais = new RepoPais(contexto);
        _repoPersona = new RepoPersona(contexto);
        _repoLiga = new RepoLiga(contexto);
        _repoEquipo = new RepoEquipo(contexto);
        _repoFutbolista = new RepoFutbolista(contexto);
        _repoSobre = new RepoSobre(contexto);
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
