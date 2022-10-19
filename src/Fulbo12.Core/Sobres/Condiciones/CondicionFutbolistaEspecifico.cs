using System.Linq.Expressions;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Sobres.Condiciones;

public class CondicionFutbolistaEspecifico : Condicion
{
    public ushort IdFutbolista { get; set; }
    public override Expression<Func<Futbolista, bool>> Expresion
        => f => f.Id == IdFutbolista;
}