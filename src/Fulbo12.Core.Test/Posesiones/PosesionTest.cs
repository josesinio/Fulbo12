using Fulbo12.Core.Posesiones.Fixtures;
using Xunit;

namespace Fulbo12.Core.Posesiones.Test
{
    public class PosesionTest : IClassFixture<PosesionesFixture>
    {
        public Posesion LuchoFabra { get; set; }
        public PosesionesFixture Fixture { get; set; }
        public PosesionTest(PosesionesFixture pf)
        {
            Fixture = pf;
            LuchoFabra = new Posesion(pf.Usuarios.Lucho, pf.Futbolistas.FFrankFabra);
        }

        [Fact]
        public void ContadoresIniciales()
        {
            Assert.Equal(1, LuchoFabra.Duenos);
            Assert.Equal(0, LuchoFabra.Goles);
            Assert.Equal(0, LuchoFabra.PartidosJugados);
        }

        [Theory]
        [InlineData(3, 3)]
        [InlineData(4, 1)]
        public void AcumuladorGoles(byte partidos, byte golesPorPartido)
        {
            //Jugar N partidos, haciendo X goles por partido
            for (byte i = 0; i < partidos; i++)
                LuchoFabra.IncrementarGoles(golesPorPartido);

            Assert.Equal(partidos * golesPorPartido, LuchoFabra.Goles);
        }

        [Fact]
        public void GolesMaximos()
        {
            //Hacer que convierta mas goles de los admitidos
            for (byte i = 0; i < Posesion.MaximosPartidosGoles/200 + 1; i++)
                LuchoFabra.IncrementarGoles(200);
            
            //Aún asi, el acumulador solo llega al máximo
            Assert.Equal(Posesion.MaximosPartidosGoles, LuchoFabra.Goles);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(7)]
        public void AcumuladorPartidos(byte partidos)
        {
            //Jugar N partidos
            for (byte i = 0; i < partidos; i++)
                LuchoFabra.IncrementarPartido();

            Assert.Equal(partidos, LuchoFabra.PartidosJugados);
        }

        [Fact]
        public void PartidosMaximo()
        {
            //Hacer que juegue más partidos de los maximos
            for (ushort i = 0; i < Posesion.MaximosPartidosGoles + 1; i++)
                LuchoFabra.IncrementarPartido();
            
            //Aún asi, el contador de partidos solo llega al máximo
            Assert.Equal(Posesion.MaximosPartidosGoles, LuchoFabra.PartidosJugados);
        }

        [Fact]
        public void IncrementarDuenoMaximo()
        {
            for (byte i = 0; i < Posesion.MaximaCantidadDuenos+1; i++)
                LuchoFabra.IncrementarDueno();
            
            Assert.Equal(Posesion.MaximaCantidadDuenos, LuchoFabra.Duenos);
        }

    }
}