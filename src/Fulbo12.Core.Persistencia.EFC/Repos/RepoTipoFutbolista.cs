using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Persistencia.EFC.Repos
{
    public class RepoTipoFutbolista : RepoGenerico<TipoFutbolista>, IRepoTipoFutbolista
    {
        public RepoTipoFutbolista(Fulbo12Contexto contexto) : base(contexto) { }
        public bool ExisteNombre(string nombre)
            => DbSet.Any(tf => tf.Nombre == nombre);
        public async Task<bool> ExisteNombreAsync(string nombre)
            => await DbSet.AnyAsync(tf => tf.Nombre == nombre);
    }
}