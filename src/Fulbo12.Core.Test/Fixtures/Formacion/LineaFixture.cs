namespace Fulbo12.Core.Formacion.Fixtures;
public class LineaFixture
{
    PosicionEnCanchaFixture PecF;
    public Linea Defensas { get; set; }
    public LineaFixture(PosicionEnCanchaFixture posicionEnCanchaFixture)
    {
        PecF = posicionEnCanchaFixture;

        var posicionesDefensa = new List<PosicionEnCancha>()
            {PecF.DFDVacante, PecF.DFCVacante, PecF.DFC, PecF.DFI};
        Defensas = new Linea(posicionesDefensa);
    }
}