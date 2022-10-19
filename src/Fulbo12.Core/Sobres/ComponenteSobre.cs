using System.Linq.Expressions;
using Fulbo12.Core.Futbol;
using Fulbo12.Core.Persistencia.Repos;

namespace Fulbo12.Core.Sobres;
public class ComponenteSobre
{
    public short Id { get; set; }
    public byte IdSobre { get; set; }
    public byte? Cantidad { get; set; }
    public virtual Expression<Func<Futbolista, bool>> Expresion { get; }
    public IEnumerable<Futbolista> TraerJugadores(IRepoFutbolista repo)
    {
        if (Cantidad is null)
            throw new NullReferenceException("No hay Cantidad asignada");

        return repo.ObtenerAlAzar(Expresion, Cantidad.Value);
    }
    public ComponenteSobre() { }
}