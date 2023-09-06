using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Test;
public class FubolistaTests : IClassFixture<FutbolFixture>
{
    FutbolistasFixture ff { get; set; }
    PosicionesFixture pf {get; set;}
    public FubolistaTests(FutbolFixture futbolistasFixture)
    {
        ff = futbolistasFixture.Futbolistas;
        pf = futbolistasFixture.Posiciones;
    }

    [Fact]
    public void MismaNacionalidad()
    {
        Assert.False(ff.FFrankFabra.MismaNacionalidad(ff.FLioMessi));
        Assert.True(ff.FLioMessi.MismaNacionalidad(ff.FMarcosRojo));
    }

    [Fact]
    public void MismaLiga()
    {
        Assert.False(ff.FLioMessi.MismaLiga(ff.FMarcosRojo));
        Assert.True(ff.FMarcosRojo.MismaLiga(ff.FFrankFabra));
    }

    [Fact]
    public void MismoEquipo()
    {
        Assert.False(ff.FLioMessi.MismoEquipo(ff.FMarcosRojo));
        Assert.True(ff.FMarcosRojo.MismoEquipo(ff.FFrankFabra));
    }
    [Fact]
    public void JuegaDe()
    {
        Assert.True(ff.FLioMessi.JuegaDe(pf.MediocampistaOfensivo));
        Assert.False(ff.FLioMessi.JuegaDe(pf.DefensorCentral));
        Assert.True(ff.FFrankFabra.JuegaDe(pf.DefensorIzquierdo));
        Assert.False(ff.FFrankFabra.JuegaDe(pf.MediaPunta));
    }
}
