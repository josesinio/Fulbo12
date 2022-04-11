namespace Fulbo12.Core.Futbol.Fixtures
{
    public class PosicionesFixture
    {
        public Posicion DefensorCentral { get; set; }
        public Posicion DefensorIzquierdo { get; set; }
        public Posicion MediaPunta { get; set; }
        public Posicion MediocampistaOfensivo { get; set; }
        public Posicion DefensorDerecho { get; set; }

        public PosicionesFixture()
        {
            DefensorDerecho = new Posicion("Defensor Derecho");
            DefensorIzquierdo = new Posicion("Defensor Izquierdo");
            DefensorCentral = new Posicion("Defensor Central");
            MediaPunta = new Posicion("Media Punta");
            MediocampistaOfensivo = new Posicion("Mediocampista Ofensivo");
        }
    }
}