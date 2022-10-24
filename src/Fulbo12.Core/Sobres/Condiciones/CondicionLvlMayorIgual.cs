using System.Linq.Expressions;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Sobres.Condiciones;

public class CondicionLvlMayorIgual : CondicionLvl
{
    public override Expression<Func<Futbolista, bool>> Expresion
        => f => f.Valoracion >= Nivel;    
}
