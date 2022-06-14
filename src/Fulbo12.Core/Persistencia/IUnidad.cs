using Fulbo12.Core.Persistencia.Repos;

namespace Fulbo12.Core.Persistencia;
public interface IUnidad
{
    IRepoPais RepoPais { get; }
    IRepoPersona RepoPersona { get; }
    void Guardar();
}