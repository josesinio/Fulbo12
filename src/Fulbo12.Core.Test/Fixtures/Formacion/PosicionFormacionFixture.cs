using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Fixtures;

public class PosicionFormacionFixture
{
    public PosicionFormacion LD { get; set; }
    public PosicionFormacion DfcMR442 { get; set; }
    public PosicionFormacion DfcMR433 {get; set; }
    private FutbolFixture Futbol { get; set; }
    private FutbolistasFixture _Futbolistas => Futbol.Futbolistas;
    public PosicionFormacionFixture()
    {

        LD = new PosicionFormacion()
        {
            IdFormacion = 1,
            Futbolista = Futbol.Futbolistas.FFAMarceloWeigandt,
            NumCamiseta = 4,
            NroAlineacion = 1,
            SuperiorY = 1000_000,
            SuperiorX = 10.1f,
            Ancho = 0,
            Largo = 10

        };

        DfcMR442 = new PosicionFormacion()
        {
            IdFormacion = 1,
            Futbolista = Futbol.Futbolistas.FMarcosRojo,
            NumCamiseta = 2,
            NroAlineacion = 1,
            SuperiorY = PosicionFormacion.LargoCancha/4,
            SuperiorX = PosicionFormacion.AnchoCancha/2,
            Ancho = PosicionFormacion.AnchoCancha/4,
            Largo = PosicionFormacion.LargoCancha/4,

        };

        DfcMR433 = new PosicionFormacion()
        {
            IdFormacion = 1,
            Futbolista = Futbol.Futbolistas.FMarcosRojo,
            NumCamiseta = 2,
            NroAlineacion = 2,
            SuperiorY = PosicionFormacion.LargoCancha/4,
            SuperiorX = PosicionFormacion.AnchoCancha/2,
            Ancho = PosicionFormacion.AnchoCancha/4,
            Largo = PosicionFormacion.LargoCancha/4,

        };
    }




}
