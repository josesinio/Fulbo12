using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fulbo12.Core;
/// <summary>
/// Clase sencilla que expone un id: byte y un string de descripción
/// </summary>
public abstract class ConNombre
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public byte Id { get; set; }

    [MaxLength(30)]
    [Required]
    public string Nombre { get; set; }
    public ConNombre(){}
    public ConNombre(string nombre) => Nombre = nombre;
    public ConNombre(string nombre, byte id) : this(nombre)
        => Id = id;
}