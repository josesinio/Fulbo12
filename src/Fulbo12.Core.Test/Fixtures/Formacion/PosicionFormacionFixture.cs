using Fulbo12.Core.Formacion;
using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Fixtures;

public class PosicionFormacionFixture
{
    public PosicionFormacion DFD { get; set; }
    public PosicionFormacion DFC { get; set; }
    public FutbolFixture Futbol { get; set; }
    private FutbolistasFixture _Futbolista => Futbol.Futbolistas;
    public PosicionFormacionFixture()
    {

        DFD = new PosicionFormacion()
        {
            IdFormacion = 1,
            Futbolista = Futbol.Futbolistas.FFAMarceloWeigandt,
            NumCamiseta = 4,
            NroAlineacion = 1,
            DerechaSuperior = 1000_000,
            IzquierdaSuperior = 10_10,
            DerechaInferior = 0_0,
            Izquierdainferior = 10_0

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
