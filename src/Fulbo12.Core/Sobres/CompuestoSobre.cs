using System.ComponentModel.DataAnnotations.Schema;

namespace Fulbo12.Core.Sobres;
public abstract class CompuestoSobre : ComponenteSobre
{
    [ForeignKey(nameof(Condicion.IdPadre))]
    public List<Condicion> Condiciones { get; set; }    
}