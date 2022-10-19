using System.Linq.Expressions;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Sobres.Compuestos;

public class CompuestoAnd : CompuestoSobre
{
    public override Expression<Func<Futbolista, bool>> Expresion
    {
        get
        {
            var expresion = this.Condiciones[0].Expresion;
            for (int i = 1; i < Condiciones.Count; i++)
            {
                expresion = PredicateExtensions.And(expresion, Condiciones[i].Expresion);
            }
            return expresion;
        }
    }
}
