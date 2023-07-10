using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Fixtures;

public class PosicionFormacionFixture
{
    public PosicionFormacion LD { get; set; }
    public PosicionFormacion DFC { get; set; }
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
            DerechaSuperior = 1000_000,
            IzquierdaSuperior = 10.1f,
            DerechaInferior = 0,
            Izquierdainferior = 10

        };

        DFC = new PosicionFormacion()
        {
            IdFormacion = 1,
            Futbolista = Futbol.Futbolistas.FMarcosRojo,
            NumCamiseta = 2,
            NroAlineacion = 1,
            DerechaSuperior = 1000_000,
            IzquierdaSuperior = 20_20,
            DerechaInferior = 0 - 5,
            Izquierdainferior = 10_0,

        };
    }




}
