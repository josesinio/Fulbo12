using Fulbo12.Core.Formacion.Fixtures;
using Fulbo12.Core.Futbol.Fixtures;
using Xunit;
using System;

namespace Fulbo12.Core.Formacion.Test
{
    public class FormacionTest : IClassFixture<FormacionFixture>
    {
        public Formacion Formacion { get; set; }
        private FutbolistasFixture FixFutbolistas { get; set; }
        static readonly string _nombre = "4 - 1 - 4 - 1";
        public FormacionTest(FormacionFixture fixture)
        {
            Formacion = fixture.CrearFormacion();
            FixFutbolistas = fixture.PosicionesEnCancha.Futbol.Futbolistas;
        }

        [Fact]
        public void CadenaFormacion()
            => Assert.Equal(_nombre, Formacion.ToString());

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(9)]
        [InlineData(5)]
        public void ExisteNumero(byte numeroCamiseta)
            => Assert.True(Formacion.ExisteNumero(numeroCamiseta));

        [Theory]
        [InlineData(0)]
        [InlineData(100)]
        public void NoExisteNumero(byte numeroCamiseta)
            => Assert.False(Formacion.ExisteNumero(numeroCamiseta));

        [Fact]
        public void NumeroDisponible()
        // Cuando se agregue arquero, hay que cambiar este 1
            => Assert.Equal(1, Formacion.NumeroDisponible);

        [Fact]
        public void NoSePuedeAgregarRepetido()
        {
            var msj = Assert.Throws<InvalidOperationException>
                (() => Formacion.AgregarSuplente(FixFutbolistas.FNicoDeLaCruz));
            Assert.Equal(Formacion._jugadorYaExiste, msj.Message);

            msj = Assert.Throws<InvalidOperationException>
                (() => Formacion.AgregarReserva(FixFutbolistas.FNicoDeLaCruz));
            Assert.Equal(Formacion._jugadorYaExiste, msj.Message);
        }

        [Fact]
        public void AgregarSuplenteOK()
        {
            Assert.Empty(Formacion.Suplentes);
            Formacion.AgregarSuplente(FixFutbolistas.FTomasPochettino);

            Assert.Single(Formacion.Suplentes);
        }

        [Fact]
        public void AgregarReservaOK()
        {
            Assert.Empty(Formacion.Suplentes);
            Formacion.AgregarSuplente(FixFutbolistas.FTomasPochettino);

            Assert.Single(Formacion.Suplentes);
        }

        [Fact]
        public void SinEspacioSuplentes()
        {
            //Completo los suplentes
            Formacion.AgregarSuplente(FixFutbolistas.FTomasPochettino);
            Formacion.AgregarSuplente(FixFutbolistas.FEliasGomez);
            Formacion.AgregarSuplente(FixFutbolistas.FFrancoPetroli);
            Formacion.AgregarSuplente(FixFutbolistas.FEzequielCenturion);
            Formacion.AgregarSuplente(FixFutbolistas.FEmanuelMammana);

            //Intento agregar como suplente a un futbolista nuevo
            var excep = Assert.Throws<InvalidOperationException>
                (() => Formacion.AgregarSuplente(FixFutbolistas.FMiltonCasco));

            Assert.Equal(Formacion._posicionesLlenas, excep.Message);
        }
    }
}