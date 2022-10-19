using System.ComponentModel.DataAnnotations.Schema;

namespace Fulbo12.Core.Sobres;

[Table("Sobre")]
public class Sobre : ConNombre
{
    [ForeignKey(nameof(ComponenteSobre.IdSobre))]
    public List<ComponenteSobre> Componentes { get; set; }
}