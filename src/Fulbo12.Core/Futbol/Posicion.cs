namespace Fulbo12.Core.Futbol;
public class Posicion : ConNombre
{
    public Posicion(string nombre) : base(nombre) { }
    public Posicion(byte id, string nombre) : base(nombre, id) { }
}