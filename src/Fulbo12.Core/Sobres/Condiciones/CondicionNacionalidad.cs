using System.Linq.Expressions;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Sobres.Condiciones;
public class CondicionNacionalidad : ComponenteSobre
{
    public byte IdPais { get; set; }
    public override Expression<Func<Futbolista, bool>> Expresion
        => f => f.Persona.Pais.Id == IdPais;
}