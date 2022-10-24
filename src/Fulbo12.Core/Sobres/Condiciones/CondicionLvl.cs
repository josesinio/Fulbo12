using System.ComponentModel.DataAnnotations.Schema;

namespace Fulbo12.Core.Sobres.Condiciones;

public abstract class CondicionLvl : Condicion
{
    [Column("nivel")]
    public byte Nivel { get; set; }
}
