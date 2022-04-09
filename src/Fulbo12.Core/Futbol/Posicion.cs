namespace Fulbo12.Core.Futbol
{
    public class Posicion
    {
        public byte Id { get; set; }
        public string Nombre { get; set; }
        public Posicion() { }
        public Posicion(string nombre) => Nombre = nombre;
    }
}