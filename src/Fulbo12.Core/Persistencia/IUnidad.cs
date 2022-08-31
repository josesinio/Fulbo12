using Fulbo12.Core.Persistencia.Repos;

namespace Fulbo12.Core.Persistencia;
public interface IUnidad
{
    IRepoPais RepoPais { get; }
    IRepoPersona RepoPersona { get; }
    IRepoLiga RepoLiga { get; }
    IRepoEquipo RepoEquipo { get; }
    void Guardar();
    Task GuardarAsync();
}