namespace Fulbo12.Core.Futbol;
public class Posicion : ConNombre
{
    public string Abreviado { get; set; }
    public Posicion() {}
    public Posicion(string nombre) : base(nombre) { }
    public Posicion(byte id, string nombre) : base(nombre, id) { }
    public Posicion(byte id, string nombre, string abreviado) : this(id, nombre)
        => Abreviado = abreviado;
    //Colección para configurar el N-N con futbolista
    public List<Futbolista> Futbolistas { get; set; }
}