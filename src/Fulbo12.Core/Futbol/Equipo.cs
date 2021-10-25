namespace Fulbo12.Core.Futbol
{
    public class Equipo
    {
        public Liga Liga { get; set; } 

        public bool MismaLiga(Equipo equipo)
            => equipo.Liga == this.Liga;
    }
}