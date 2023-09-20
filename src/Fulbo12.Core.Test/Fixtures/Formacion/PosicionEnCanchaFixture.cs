using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Fixtures;
public class PosicionEnCanchaFixture
{
    public PosicionEnCancha POVacante { get; set; }
    public PosicionEnCancha DFI { get; set; }
    public PosicionEnCancha DFC { get; set; }
    public PosicionEnCancha DFCVacante { get; set; }
    public PosicionEnCancha DFDVacante { get; set; }
    public PosicionEnCancha PecNicoDeLaCruz { get; set; }
    public PosicionEnCancha PecTomasPochettino { get; set; }
    public PosicionEnCancha PecFrancoPetroli { get; set; }
    public PosicionEnCancha PecEzequielCenturion { get; set; }
    public PosicionEnCancha PecEmanuelMammana { get; set; }
    public PosicionEnCancha PecMiltonCasco { get; set; }
    public PosicionEnCancha PecEliasGomez { get; set; }
    public FutbolFixture Futbol { get; }
    private PosicionesFixture _Posiciones => Futbol.Posiciones;
    public const byte NroFabra = 3;
    public const byte nroRojo = 6;
    public PosicionEnCanchaFixture(FutbolFixture futbol)
    {
        Futbol = futbol;
        DFDVacante = new PosicionEnCancha(_Posiciones.DefensorDerecho)
        {
            NumeroCamiseta = 4
        };

        DFCVacante = new PosicionEnCancha(_Posiciones.DefensorCentral)
        {
            NumeroCamiseta = 2
        };

        DFI = new PosicionEnCancha(_Posiciones.DefensorIzquierdo)
        {
            NumeroCamiseta = NroFabra,
            Futbolista = Futbol.Futbolistas.FFrankFabra
        };

        DFC = new PosicionEnCancha(_Posiciones.DefensorCentral)
        {
            NumeroCamiseta = nroRojo,
            Futbolista = Futbol.Futbolistas.FMarcosRojo
        };

        PecNicoDeLaCruz = new PosicionEnCancha(posicion: _Posiciones.MedioCentro)
        {
            Futbolista = Futbol.Futbolistas.FNicoDeLaCruz
        };

        PecTomasPochettino = new PosicionEnCancha(_Posiciones.MedioCentro)
        {
            Futbolista = Futbol.Futbolistas.FTomasPochettino
        };

        PecFrancoPetroli = new PosicionEnCancha(_Posiciones.MedioCentro)
        {
            Futbolista = Futbol.Futbolistas.FFrancoPetroli
        };

        PecEzequielCenturion = new PosicionEnCancha(_Posiciones.Arquero)
        {
            Futbolista = Futbol.Futbolistas.FEzequielCenturion
        };

        PecEmanuelMammana = new PosicionEnCancha(_Posiciones.Arquero)
        {
            Futbolista = Futbol.Futbolistas.FEmanuelMammana
        };

        PecMiltonCasco = new PosicionEnCancha(_Posiciones.DefensorIzquierdo)
        {
            Futbolista = Futbol.Futbolistas.FMiltonCasco
        };

        PecEliasGomez = new PosicionEnCancha(_Posiciones.MedioCentro)
        {
            Futbolista = Futbol.Futbolistas.FEliasGomez
        };

        POVacante = new PosicionEnCancha(_Posiciones.Arquero);
    }
    public PosicionEnCanchaFixture() : this(new FutbolFixture())
    {

    }
}