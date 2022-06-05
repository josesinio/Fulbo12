using Fulbo12.Core.Formacion.Fixtures;
using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Formacion.Test;
[Trait("Category", "Formacion")]
public class FormacionTest : IClassFixture<FormacionFixture>
{
    public Formacion Formacion { get; set; }
    private FutbolistasFixture FixFutbolistas { get; set; }
    public PosicionEnCanchaFixture PecF { get; set; }
    static readonly string _nombre = "4 - 1 - 4 - 1";
    public FormacionTest(FormacionFixture fixture)
    {
        Formacion = fixture.CrearFormacion();
        FixFutbolistas = fixture.PosicionesEnCancha.Futbol.Futbolistas;
        PecF = fixture.PosicionesEnCancha;
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
        => Assert.Equal(12, Formacion.NumeroDisponible);

    [Fact]
    public void NoSePuedeAgregarRepetido()
    {
        var msj = Assert.Throws<InvalidOperationException>
            (() => Formacion.AgregarSuplente(PecF.PecNicoDeLaCruz));
        Assert.Equal(Formacion._jugadorYaExiste, msj.Message);

        msj = Assert.Throws<InvalidOperationException>
            (() => Formacion.AgregarReserva(PecF.PecNicoDeLaCruz));
        Assert.Equal(Formacion._jugadorYaExiste, msj.Message);
    }

    [Fact]
    public void AgregarSuplenteOK()
    {
        Assert.Empty(Formacion.Suplentes);
        Formacion.AgregarSuplente(PecF.PecTomasPochettino);

        Assert.Single(Formacion.Suplentes);
    }

    [Fact]
    public void AgregarReservaOK()
    {
        Assert.Empty(Formacion.Suplentes);
        Formacion.AgregarSuplente(PecF.PecTomasPochettino);

        Assert.Single(Formacion.Suplentes);
    }

    [Fact]
    public void SinEspacioSuplentes()
    {
        //Completo los suplentes
        Formacion.AgregarSuplente(PecF.PecTomasPochettino);
        Formacion.AgregarSuplente(PecF.PecEliasGomez);
        Formacion.AgregarSuplente(PecF.PecFrancoPetroli);
        Formacion.AgregarSuplente(PecF.PecEzequielCenturion);
        Formacion.AgregarSuplente(PecF.PecEmanuelMammana);

        //Intento agregar como suplente a un futbolista nuevo
        var excep = Assert.Throws<InvalidOperationException>
            (() => Formacion.AgregarSuplente(PecF.PecMiltonCasco));

        Assert.Equal(Formacion._posicionesLlenas, excep.Message);
    }
}