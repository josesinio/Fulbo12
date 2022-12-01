using System.Diagnostics.CodeAnalysis;

namespace Fulbo12.Core.Futbol;

public class TipoFutbolista : ConNombre
{

    public bool Especial { get; set; }

    [SetsRequiredMembers]
    public TipoFutbolista(string nombre, bool especial = false)
        => (Nombre, Especial) = (nombre, especial);
    [SetsRequiredMembers]
    public TipoFutbolista(byte id, string nombre, bool especial = false)
        : this (nombre, especial) => Id = id;
    public TipoFutbolista() { }
}