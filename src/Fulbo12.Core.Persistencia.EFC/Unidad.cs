using Fulbo12.Core.Persistencia.EFC.Repos;

namespace Fulbo12.Core.Persistencia.EFC;
public class Unidad : IUnidad
{
    public IRepoPais RepoPais => throw new NotImplementedException();
    RepoPais repoPais;
    private readonly Fulbo12Contexto Contexto;
    public Unidad(Fulbo12Contexto contexto)
    {
        Contexto = contexto;
        repoPais = new RepoPais(contexto);
    }
    public void Guardar() => Contexto.SaveChanges();
}
