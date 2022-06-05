using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Test;
public class FubolistaTests : IClassFixture<FutbolFixture>
{
    FutbolFixture ff { get; set; }
    public FubolistaTests(FutbolFixture futbolistasFixture)
        => ff = futbolistasFixture;

    [Fact]
    public void MismaNacionalidad()
    {
        Assert.False(ff.Futbolistas.FFrankFabra.MismaNacionalidad(ff.Futbolistas.FLioMessi));
        Assert.True(ff.Futbolistas.FLioMessi.MismaNacionalidad(ff.Futbolistas.FMarcosRojo));
    }

    [Fact]
    public void MismaLiga()
    {
        Assert.False(ff.Futbolistas.FLioMessi.MismaLiga(ff.Futbolistas.FMarcosRojo));
        Assert.True(ff.Futbolistas.FMarcosRojo.MismaLiga(ff.Futbolistas.FFrankFabra));
    }

    [Fact]
    public void MismoEquipo()
    {
        Assert.False(ff.Futbolistas.FLioMessi.MismoEquipo(ff.Futbolistas.FMarcosRojo));
        Assert.True(ff.Futbolistas.FMarcosRojo.MismoEquipo(ff.Futbolistas.FFrankFabra));
    }
    [Fact]
    public void JuegaDe()
    {
        Assert.True(ff.Futbolistas.FLioMessi.JuegaDe(ff.Posiciones.MediocampistaOfensivo));
        Assert.False(ff.Futbolistas.FLioMessi.JuegaDe(ff.Posiciones.DefensorCentral));
        Assert.True(ff.Futbolistas.FFrankFabra.JuegaDe(ff.Posiciones.DefensorIzquierdo));
        Assert.False(ff.Futbolistas.FFrankFabra.JuegaDe(ff.Posiciones.MediaPunta));
    }
}
