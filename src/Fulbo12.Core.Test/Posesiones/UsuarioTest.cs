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
        public Usuario Lucho {get; set;}
        readonly uint _minima = 500;
        readonly uint _compra = 2500;
        readonly uint _monedas = 800;


        public UsuarioTest(PosesionesFixture fixture)
        {
            Fixture = fixture.Futbolistas;
            Arturo = fixture.Usuarios.Arturo;
            Lucho = fixture.Usuarios.Lucho;
            Posesion = new Posesion(Arturo, Fixture.FLioMessi);
            fixture.BlanquearUsuario(Arturo);
        }

        [Fact]
        public void Constructor()
        {
            Assert.Equal<uint>(0, Arturo.Monedas);
            Assert.Empty(Arturo.Posesiones);
            Assert.Empty(Arturo.NuevasPosesiones);
            Assert.Empty(Arturo.Transferibles);
        }

        [Fact]
        public void SiPoseeFutbolista()
        {
            ArturoAgregaNovedadYLuegoPosesion();

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
            ArturoAgregaNovedadYLuegoPosesion();

            var ex = Assert.Throws<InvalidOperationException>(() => Arturo.AgregarPosesion(Posesion));
            Assert.Equal(Usuario._futbolistaEnPosesion, ex.Message);
        }

        [Fact]
        public void AgregarFutbolistaNoPoseido()
        {
            ArturoAgregaNovedadYLuegoPosesion();

            Assert.Single(Arturo.Posesiones);
        }

        private void ArturoAgregaNovedadYLuegoPosesion()
        {
            Arturo.AgregarNovedad(Posesion);
            Arturo.AgregarPosesion(Posesion);
        }

        [Fact]
        public void SiAgregaTransferible()
        {
            Arturo.AgregarNovedad(Posesion);
            Assert.Empty(Arturo.Transferibles);
            Assert.Single(Arturo.NuevasPosesiones);

            Arturo.AgregarTransferible(Posesion);
            Assert.Empty(Arturo.NuevasPosesiones);
            Assert.Single(Arturo.Transferibles);
        }

        [Fact]
        public void NoAgregaTransferible()
        {
            Arturo.AgregarTransferible(Posesion);
            Assert.Empty(Arturo.Transferibles);
        }

        [Fact]
        public void SiPublica()
        {
            Arturo.AgregarNovedad(Posesion);
            Arturo.AgregarTransferible(Posesion);
            var publicacion = new Publicacion(Posesion, _minima, _compra, 1);
            Arturo.Publicar(publicacion);

            Assert.Empty(Arturo.Transferibles);
            Assert.Single(Arturo.Publicaciones);
            Assert.Equal(_minima, publicacion.OfertaMinima);
            Assert.Equal(_compra, publicacion.Compra);
        }

        [Fact]
        public void NoPublica()
        {
            Arturo.AgregarNovedad(Posesion);
            var publicacion = new Publicacion(Posesion, _minima, _compra, 1);
            Arturo.Publicar(publicacion);

            Assert.Empty(Arturo.Transferibles);
            Assert.Empty(Arturo.Publicaciones);
        }

        [Fact]
        public void SiTieneAlMenos()
        {
            Arturo.Acreditar(_monedas);

            Assert.True(Arturo.TieneAlMenos(_monedas));
        }

        [Fact]
        public void NoTieneAlMenos()
        {
            Arturo.Acreditar(_monedas);

            Assert.False(Arturo.TieneAlMenos(_monedas + 1));
        }

        [Fact]
        public void NoPuedeOfertarPropia()
        {
            Arturo.AgregarNovedad(Posesion);
            Arturo.AgregarTransferible(Posesion);
            var publicacion = new Publicacion(Posesion, _minima, _compra, 1);
            Arturo.Publicar(publicacion);
            Arturo.Acreditar(_monedas);

            var ex = Assert.Throws<InvalidOperationException>(() => Arturo.Ofertar(publicacion, _minima));
            Assert.Equal(Usuario._mismoVendedor, ex.Message);
        }

        [Fact]
        public void NoPuedeOfertarNoAlcanza()
        {
            Arturo.AgregarNovedad(Posesion);
            Arturo.AgregarTransferible(Posesion);
            var publicacion = new Publicacion(Posesion, _minima, _compra, 1);
            Arturo.Publicar(publicacion);

            var ex = Assert.Throws<InvalidOperationException>(() => Arturo.Ofertar(publicacion, _minima));
            Assert.Equal(Usuario._noPoseeMonedasSuficientes, ex.Message);
        }

        [Fact]
        public void LuchoSiOferta()
        {
            Arturo.AgregarNovedad(Posesion);
            Arturo.AgregarTransferible(Posesion);
            var publicacion = new Publicacion(Posesion, _minima, _compra, 1);
            Arturo.Publicar(publicacion);
            
            Lucho.Acreditar(_minima);
            Lucho.Ofertar(publicacion, _minima);
            
            Assert.Equal<uint>(0 , Lucho.Monedas);
            Assert.Same(Lucho, publicacion.Ofertante);
            Assert.Equal(_minima, publicacion.OfertaOMinima);
        }
    }
}