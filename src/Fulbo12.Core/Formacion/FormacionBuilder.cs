using System.Diagnostics.CodeAnalysis;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Formacion;
public class FormacionBuilder
{
    public Formacion Formacion { get; private set; } = null!;
    private Linea? _linea { get; set; }

    public FormacionBuilder(PosicionEnCancha arquero) => IniciarFormacion(arquero);
    public FormacionBuilder IniciarFormacion(PosicionEnCancha arquero)
    {
        Formacion = new Formacion(arquero);
        _linea = null;
        return this;
    }
    public FormacionBuilder AgregarLinea()
    {
        _linea = new Linea();
        return AgregarLinea(_linea);
    }
    public FormacionBuilder AgregarLinea(Linea linea)
    {
        this._linea = linea;
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
        if (_linea is null)
            throw new InvalidOperationException("No se puede agregar posición si no hay linea");

        posicionEnCancha.NumeroCamiseta ??= Formacion.NumeroDisponible;
        _linea.Posiciones.Add(posicionEnCancha);
        return this;
    }
    public FormacionBuilder AgregarArquero(Futbolista futbolista, byte? nro = null)
    {
        var Arquero = new PosicionEnCancha()
        {
            Futbolista = futbolista,
            Posicion = new Posicion() { Nombre = "Arquero", Abreviado = "PO" },
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