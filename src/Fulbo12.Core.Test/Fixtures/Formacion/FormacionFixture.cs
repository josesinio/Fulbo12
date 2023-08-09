
using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Fixtures;
public class FormacionFixture
{
    public PosicionEnCanchaFixture PosicionesEnCancha { get; set; }
    public PosicionFormacionFixture PosicionFormacion { get; set; }
    public LineaFixture Lineas { get; set; }
    private FormacionBuilder _fb;
    private PosicionEnCancha _Arquero => PosicionesEnCancha.POVacante;


    public FormacionFixture(FutbolistasFixture futbolista)
    {
        PosicionesEnCancha = new PosicionEnCanchaFixture();
        PosicionFormacion = new PosicionFormacionFixture(futbolista);
        Lineas = new LineaFixture(PosicionesEnCancha);
        _fb = new FormacionBuilder(_Arquero);
    }
    public Formacion CrearFormacion()
    {
        var futbolistas = PosicionesEnCancha.Futbol.Futbolistas;
        var posiciones = PosicionesEnCancha.Futbol.Posiciones;
        return _fb.IniciarFormacion(_Arquero)
                    .AgregarLinea(Lineas.Defensas)
                    .AgregarLinea()
                        .AgregarPosicion(futbolistas.FEnzoPerez, posiciones.MediocampistaDefensivo, 5)
                    .AgregarLinea()
                        .AgregarPosicion(futbolistas.FSantiagoSimon, posiciones.MediocampistaDerecho, 8)
                        .AgregarPosicion(futbolistas.FEnzoFernandez, posiciones.MedioCentro, 7)
                        .AgregarPosicion(futbolistas.FNicoDeLaCruz, posiciones.MedioCentro, 10)
                        .AgregarPosicion(futbolistas.FEsequielBarco, posiciones.MediocampistaIzquierdo, 11)
                    .AgregarLinea()
                        .AgregarPosicion(futbolistas.FJulianAlvarez, posiciones.DelanteroCentral, 9)
                    .AgregarArquero(futbolistas.FFrancoArmani, 1)
                    .Formacion;
    }

}