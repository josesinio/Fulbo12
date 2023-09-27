using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Fixtures;

public class PosicionFormacionFixture
{
    public FutbolistasFixture Futbolistas { get; }
    public PosicionFormacion LDMW442 { get; set; }
    public PosicionFormacion DfcMR442 { get; set; }
    public PosicionFormacion DfcMR433 { get; set; }
    public PosicionFormacion MCEF433 { get; set; }

    public PosicionFormacionFixture(FutbolistasFixture futbolistas)
    {
        Futbolistas = futbolistas;

        MCEF433 = new PosicionFormacion()
        {
            IdFormacion = 2,
            Futbolista = Futbolistas.FEnzoFernandez,
            NumCamiseta = 5,
            NroAlineacion = 2,
            SuperiorY = PosicionFormacion.LargoCancha / 1 - 5,
            SuperiorX = PosicionFormacion.AnchoCancha / 1 - 5,
            Ancho = PosicionFormacion.AnchoCancha / 3,
            Largo = PosicionFormacion.LargoCancha / 3,
        };

        LDMW442 = new PosicionFormacion()
        {
            IdFormacion = 1,
            Futbolista = Futbolistas.FFAMarceloWeigandt,
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
            Futbolista = Futbolistas.FMarcosRojo,
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
            Futbolista = Futbolistas.FMarcosRojo,
            NumCamiseta = 2,
            NroAlineacion = 2,
            SuperiorY = PosicionFormacion.LargoCancha / 4,
            SuperiorX = PosicionFormacion.AnchoCancha / 2,
            Ancho = PosicionFormacion.AnchoCancha / 4,
            Largo = PosicionFormacion.LargoCancha / 4,

        };
        DfcMR433.InstanciarArea();
    }
    public PosicionFormacionFixture() : this(new FutbolFixture().Futbolistas)
    {

    }
    


}
