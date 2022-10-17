namespace Fulbo12.Core.Futbol;

public class TipoFutbolista : ConNombre
{
    public bool Especial { get; set; }
    public TipoFutbolista(string nombre) : base(nombre) { }
}