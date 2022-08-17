namespace Fulbo12.Core.Futbol;
public class Posicion : ConNombre
{
    public Posicion(string nombre) : base(nombre) { }
    public Posicion(byte id, string nombre) : base(nombre, id) { }
    //Colección para configurar el N-N con futbolista
    public List<Futbolista> Futbolistas { get; set; }
}