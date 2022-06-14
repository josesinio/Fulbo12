namespace Fulbo12.Core;
public class Pais : ConNombre
{
    public Pais(string nombre) : base(nombre) { }
    public Pais(byte id, string nombre) : base(nombre, id) { }
}