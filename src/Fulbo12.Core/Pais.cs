namespace Fulbo12.Core;
public class Pais : ConNombre
{
    public string Abreviatura { get; set; }
    public Pais() : base() { }
    public Pais(string nombre, string abreviatura) : base(nombre)
        => Abreviatura = abreviatura;
    public Pais(byte id, string nombre, string abreviatura) : base(nombre, id)
        => Abreviatura = abreviatura;
}