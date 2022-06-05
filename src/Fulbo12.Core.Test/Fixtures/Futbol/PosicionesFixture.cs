namespace Fulbo12.Core.Futbol.Fixtures;
public class PosicionesFixture
{
    public Posicion DefensorCentral { get; set; }
    public Posicion DefensorIzquierdo { get; set; }
    public Posicion MediaPunta { get; set; }
    public Posicion MediocampistaOfensivo { get; set; }
    public Posicion DefensorDerecho { get; set; }
    public Posicion Arquero { get; set; }
    public Posicion MediocampistaDefensivo { get; set; }
    public Posicion MediocampistaDerecho { get; set; }
    public Posicion MedioCentro { get; set; }
    public Posicion MediocampistaIzquierdo { get; set; }
    public Posicion DelanteroCentral { get; set; }

    public PosicionesFixture()
    {
        DefensorDerecho = new Posicion("Defensor Derecho");
        DefensorIzquierdo = new Posicion("Defensor Izquierdo");
        DefensorCentral = new Posicion("Defensor Central");
        MediaPunta = new Posicion("Media Punta");
        MediocampistaOfensivo = new Posicion("Mediocampista Ofensivo");
        Arquero = new Posicion("Arquero");
        MediocampistaDefensivo = new Posicion("Mediocampista Defensivo");
        MediocampistaDerecho = new Posicion("Mediocampista Derecho");
        MedioCentro = new Posicion("Medio Centro");
        MediocampistaIzquierdo = new Posicion("Mediocampista Izquierdo");
        DelanteroCentral = new Posicion("Delantero Centreal");
    }
}