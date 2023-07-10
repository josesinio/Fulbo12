namespace Fulbo12.Core.Futbol.Fixtures;
public class PosicionesFixture
{
    private byte _id = 0;
    private byte _Id => ++_id;
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
    public Posicion LateralDerecho { get; set; }

    public PosicionesFixture()
    {
        Arquero = new Posicion(_Id, "Arquero", "PO");
        DefensorDerecho = new Posicion(_Id, "Defensor Derecho", "DFD");
        DefensorIzquierdo = new Posicion(_Id, "Defensor Izquierdo", "DFI");
        DefensorCentral = new Posicion(_Id, "Defensor Central", "DFC");
        MediaPunta = new Posicion(_Id, "Media Punta", "MP");
        MediocampistaOfensivo = new Posicion(_Id, "Mediocampista Ofensivo", "MCO");
        MediocampistaDefensivo = new Posicion(_Id, "Mediocampista Defensivo", "MCD");
        MediocampistaDerecho = new Posicion(_Id, "Mediocampista Derecho", "MD");
        MedioCentro = new Posicion(_Id, "Medio Centro", "MC");
        MediocampistaIzquierdo = new Posicion(_Id, "Mediocampista Izquierdo", "MI");
        DelanteroCentral = new Posicion(_Id, "Delantero Central", "DC");
        LateralDerecho = new Posicion(_Id, "Lateral Derecho", "LD");
    }
}