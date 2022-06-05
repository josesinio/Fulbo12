namespace Fulbo12.Core;
public class Pais
{
    public byte Id { get; set; }
    public string  Nombre { get; set; }
    public Pais() {}
    public Pais(string nombre) => Nombre = nombre;
}