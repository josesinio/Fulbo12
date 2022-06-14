using System.ComponentModel.DataAnnotations.Schema;

namespace Fulbo12.Core;
public class Persona
{
    [Column("idPersona")][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public short Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    
    [Column("nacimiento")]
    public DateOnly Nacimiento { get; set; }
    
    [Column("peso")]
    public float Peso { get; set; }
    
    [Column("altura")]
    public float Altura { get; set; }
    public Pais Pais { get; set; }

    [NotMapped]
    public byte Edad
    {
        get
        {
            var hoy = DateOnly.FromDateTime(DateTime.Today);
            var anios = Convert.ToByte((hoy.Year - Nacimiento.Year));

            if (hoy.Month < Nacimiento.Month)
            {
                return --anios;
            }
            else if (hoy.Month == Nacimiento.Month && hoy.Day >= Nacimiento.Day)
            {
                return anios;
            }
            else return --anios;
        }
    }
    public bool MismaNacionalidad(Persona persona)
        => persona.Pais == this.Pais;
}