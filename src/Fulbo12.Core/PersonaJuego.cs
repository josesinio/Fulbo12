using System.ComponentModel.DataAnnotations.Schema;

namespace Fulbo12.Core;
public class PersonaJuego : PersonaBase
{
    [Column("peso")]
    public float Peso { get; set; }

    [Column("altura")]
    public float Altura { get; set; }
}