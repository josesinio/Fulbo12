using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Fixtures;

public class PosicionFormacionFixture
{
    private readonly FutbolistasFixture _futbolistas;
    public PosicionFormacion LDMW442 { get; set; }
    public PosicionFormacion DfcMR442 { get; set; }
    public PosicionFormacion DfcMR433 { get; set; }

    public PosicionFormacionFixture(FutbolistasFixture futbolistas)
    {
        _futbolistas = futbolistas;

        LDMW442 = new PosicionFormacion()
        {
            IdFormacion = 1,
            Futbolista = _futbolistas.FFAMarceloWeigandt,
            NumCamiseta = 4,
            NroAlineacion = 1,
            SuperiorY = PosicionFormacion.LargoCancha,
            SuperiorX = PosicionFormacion.AnchoCancha / 4,
            Ancho = PosicionFormacion.AnchoCancha / 4,
            Largo = PosicionFormacion.LargoCancha,

        };

        DfcMR442 = new PosicionFormacion()
        {
            IdFormacion = 1,
            Futbolista = _futbolistas.FMarcosRojo,
            NumCamiseta = 2,
            NroAlineacion = 1,
            SuperiorY = PosicionFormacion.LargoCancha / 4,
            SuperiorX = PosicionFormacion.AnchoCancha / 2,
            Ancho = PosicionFormacion.AnchoCancha / 4,
            Largo = PosicionFormacion.LargoCancha / 4,

        };

        DfcMR433 = new PosicionFormacion()
        {
            IdFormacion = 2,
            Futbolista = _futbolistas.FMarcosRojo,
            NumCamiseta = 2,
            NroAlineacion = 2,
            SuperiorY = PosicionFormacion.LargoCancha / 4,
            SuperiorX = PosicionFormacion.AnchoCancha / 2,
            Ancho = PosicionFormacion.AnchoCancha / 4,
            Largo = PosicionFormacion.LargoCancha / 4,

        };
    }
    public PosicionFormacionFixture() : this(new FutbolFixture().Futbolistas)
    {
        
    }




}
