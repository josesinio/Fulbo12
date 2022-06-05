using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Formacion;
public class FormacionBuilder
{
    public Formacion Formacion { get; private set; }
    private Linea linea { get; set; }
    public FormacionBuilder() => IniciarFormacion();
    public FormacionBuilder IniciarFormacion()
    {
        Formacion = new Formacion();
        linea = null;
        return this;
    }
    public FormacionBuilder AgregarLinea()
    {
        linea = new Linea();
        return AgregarLinea(linea);
    }
    public FormacionBuilder AgregarLinea(Linea linea)
    {
        this.linea = linea;
        Formacion.Lineas.Add(linea);
        return this;
    }
    public FormacionBuilder AgregarPosicion(Futbolista futbolista, Posicion posicion, byte? nro = null)
    {
        var posicionEnCancha = new PosicionEnCancha()
        {
            Futbolista = futbolista,
            Posicion = posicion,
            NumeroCamiseta = nro ?? Formacion.NumeroDisponible
        };
        return AgregarPosicion(posicionEnCancha);
    }
    public FormacionBuilder AgregarPosicion(PosicionEnCancha posicionEnCancha)
    {
        posicionEnCancha.NumeroCamiseta ??= Formacion.NumeroDisponible;
        linea.Posiciones.Add(posicionEnCancha);
        return this;
    }
    public FormacionBuilder AgregarArquero(Futbolista futbolista, byte? nro = null)
    {
        var Arquero = new PosicionEnCancha()
        {
            Futbolista = futbolista,
            Posicion = new("Arquero"),
            NumeroCamiseta = nro ?? Formacion.NumeroDisponible
        };
        return AgregarArquero(Arquero);
    }
    public FormacionBuilder AgregarArquero(PosicionEnCancha posicionEnCancha)
    {
        posicionEnCancha.NumeroCamiseta ??= Formacion.NumeroDisponible;
        Formacion.Arquero = posicionEnCancha;
        return this;
    }
}