using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Fixtures
{
    public class PosicionEnCanchaFixture
    {
        public PosicionEnCancha DFI { get; set; }
        public FutbolFixture Futbol { get; set; }
        public PosicionEnCanchaFixture()
        {
            Futbol = new FutbolFixture();
            DFI = new PosicionEnCancha()
            {
                NumeroCamiseta = 3,
                Posicion = Futbol.Posiciones.DefensorIzquierdo,
                Futbolista = Futbol.Futbolistas.FFrankFabra
            };
        }        
    }
}