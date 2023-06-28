using Fulbo12.Core.Formacion;
using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Fixtures;

public class PosicionFormacionFixture
{
    public PosicionFormacion  DFD {get; set;}
    public PosicionFormacion DFC {get; set;}
    public FutbolFixture Futbol {get; set;} 
    private  PosicionesFixture _Posiciones => Futbol.Posiciones;
    public  byte  nroDFD {get; set;} 
    public byte nroDFC {get; set;} 
    public PosicionFormacionFixture ()
    {
        Futbol = new FutbolFixture(); 

        DFD = new PosicionFormacion(_Posiciones.DefensorDerecho);
        {
            nroDFD = 4;
        }

        DFC = new PosicionFormacion(_Posiciones.DefensorCentral);
        {
            nroDFC = 2;
        }
    }




}
