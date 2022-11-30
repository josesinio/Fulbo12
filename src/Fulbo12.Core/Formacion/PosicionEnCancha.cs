using System.Diagnostics.CodeAnalysis;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Formacion;
public class PosicionEnCancha
{
    public Futbolista? Futbolista { get; set; } = null;
    public required Posicion Posicion { get; set; }
    public byte? NumeroCamiseta { get; set; } = null;
    public PosicionEnCancha() { }
    
    [SetsRequiredMembers]
    public PosicionEnCancha(Posicion posicion) => Posicion = posicion;
    public byte QuimicaJugador
    {
        get
        {
            if (HayJugador) return 0; else return 10;
        }
    }
    public bool HayJugador => Futbolista is not null;
    public bool EsPersona(PersonaJuego persona)
        => HayJugador && Futbolista!.Persona == persona;
    public bool EsNumero(byte numCamiseta) => NumeroCamiseta.Equals(numCamiseta);
    public PersonaJuego? Persona => HayJugador ? Futbolista!.Persona : null;
}