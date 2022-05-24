using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Fixtures
{
    public class PosicionEnCanchaFixture
    {
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
        public FutbolFixture Futbol { get; set; }
        public const byte NroFabra = 3;
        public const byte nroRojo = 6;
        public PosicionEnCanchaFixture()
        {
            Futbol = new FutbolFixture();

            DFDVacante = new PosicionEnCancha(Futbol.Posiciones.DefensorDerecho)
            {
                NumeroCamiseta = 4
            };

            DFCVacante = new PosicionEnCancha(Futbol.Posiciones.DefensorCentral)
            {
                NumeroCamiseta = 2
            };

            DFI = new PosicionEnCancha(Futbol.Posiciones.DefensorIzquierdo)
            {
                NumeroCamiseta = NroFabra,
                Futbolista = Futbol.Futbolistas.FFrankFabra
            };

            DFC = new PosicionEnCancha(Futbol.Posiciones.DefensorCentral)
            {
                NumeroCamiseta = nroRojo,
                Futbolista = Futbol.Futbolistas.FMarcosRojo
            };

            PecNicoDeLaCruz = new PosicionEnCancha(posicion: null)
            {
                Futbolista = Futbol.Futbolistas.FNicoDeLaCruz
            };

            PecTomasPochettino = new PosicionEnCancha(posicion: null)
            {
                Futbolista = Futbol.Futbolistas.FTomasPochettino
            };

            PecFrancoPetroli = new PosicionEnCancha(posicion: null)
            {
                Futbolista = Futbol.Futbolistas.FFrancoPetroli
            };

            PecEzequielCenturion = new PosicionEnCancha(posicion: null)
            {
                Futbolista = Futbol.Futbolistas.FEzequielCenturion
            };

            PecEmanuelMammana = new PosicionEnCancha(posicion: null)
            {
                Futbolista = Futbol.Futbolistas.FEmanuelMammana
            };

            PecMiltonCasco = new PosicionEnCancha(posicion: null)
            {
                Futbolista = Futbol.Futbolistas.FMiltonCasco
            };

            PecEliasGomez = new PosicionEnCancha(posicion: null)
            {
                Futbolista = Futbol.Futbolistas.FEliasGomez
            };
        }
    }
}