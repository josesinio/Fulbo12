using Xunit;
using Fulbo12.Core.Posesiones.Fixtures;
using Fulbo12.Core.Futbol.Fixtures;
using System;

namespace Fulbo12.Core.Posesiones.Test
{
    [Trait("Category", "Posesion")]
    public class UsuarioTest : IClassFixture<PosesionesFixture>
    {
        public FutbolistasFixture Fixture { get; set; }
        public Posesion Posesion { get; set; }
        public Usuario Arturo { get; set; }


        public UsuarioTest(PosesionesFixture fixture)
        {
            Fixture = fixture.Futbolistas;
            Arturo = fixture.Usuarios.Arturo;
            Posesion = new Posesion(Arturo, Fixture.FLioMessi);
            Arturo.Posesiones.Clear();
            Arturo.NuevasPosesiones.Clear();
        }

        [Fact]
        public void Constructor()
        {
            Assert.Equal<uint>(0, Arturo.Monedas);
            Assert.Empty(Arturo.Posesiones);
            Assert.Empty(Arturo.NuevasPosesiones);
        }

        [Fact]
        public void SiPoseeFutbolista()
        {
            Arturo.AgregarNovedad(Posesion);
            Arturo.AgregarPosesion(Posesion);

            Assert.True(Arturo.PoseeFutbolista(Fixture.FLioMessi));
        }

        [Fact]
        public void NoPoseeFutbolista()
        {
            Assert.False(Arturo.PoseeFutbolista(Fixture.FBrunoZuculini));
        }
        [Fact]
        public void AgregarFutbolistaYaPoseido()
        {
            Arturo.AgregarNovedad(Posesion);
            Arturo.AgregarPosesion(Posesion);

            var ex = Assert.Throws<InvalidOperationException>(() => Arturo.AgregarPosesion(Posesion));
            Assert.Equal(Usuario._futbolistaEnPosesion, ex.Message);
        }
        [Fact]
        public void AgregarFutbolistaNoPoseido()
        {
            Arturo.AgregarNovedad(Posesion);
            Arturo.AgregarPosesion(Posesion);

            Assert.Single(Arturo.Posesiones);
        }
    }
}