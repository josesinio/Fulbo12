using System.Diagnostics.CodeAnalysis;

namespace Fulbo12.Core.Futbol;
public class Posicion : ConNombre
{
    public required string Abreviado { get; set; }
    public Posicion() {}
    
    [SetsRequiredMembers]
    public Posicion(byte id, string nombre, string abreviado) : base(nombre, id)
        => Abreviado = abreviado;
    //Colección para configurar el N-N con futbolista
    public List<Futbolista> Futbolistas { get; set; } = null!;
}