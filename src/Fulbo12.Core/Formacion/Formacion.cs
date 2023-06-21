using System.Text;

namespace Fulbo12.Core.Formacion;
public class Formacion
{
    public int IdFormacion {get; set;}
    public static readonly byte CantidadTitulares = 11;
    public static readonly byte CantidadSuplentes = 5;
    public static readonly byte CantidadReserva = 5;
    public static readonly byte CantidadTotalJugadores =
        Convert.ToByte(CantidadTitulares + CantidadSuplentes + CantidadReserva);
    public static readonly string _jugadorYaExiste = "Jugador ya existe en la formación";
    public static readonly string _posicionesLlenas = "No es posible agregar más jugadores en esta parte";

    public List<Linea> Lineas { get; set; }
    public List<PosicionEnCancha> Suplentes { get; set; }
    public List<PosicionEnCancha> Reserva { get; set; }
    public PosicionEnCancha Arquero { get; set; }
    public Formacion(PosicionEnCancha arquero)
    {
        Arquero = arquero;
        Lineas = new List<Linea>();
        Suplentes = new();
        Reserva = new();
    }
    public byte QuimicaJugadores
        => Convert.ToByte(Lineas.Sum(l => l.QuimicaJugadores));
    private IEnumerable<byte> PosicionesPorLinea
        => Lineas.Select(l => l.CantidadPosiciones);
    public override string ToString()
        => new StringBuilder().AppendJoin(" - ", PosicionesPorLinea).ToString();
    public bool ExisteNumero(byte numeroCamiseta)
        => Arquero.EsNumero(numeroCamiseta)
        || Lineas.Any(l => l.ExisteNumero(numeroCamiseta))
        || Suplentes.Any(s => s.EsNumero(numeroCamiseta))
        || Reserva.Any(r => r.EsNumero(numeroCamiseta));
    public byte NumeroDisponible
    {
        get
        {
            for (byte i = 1; i < CantidadTotalJugadores; i++)
            {
                if (!ExisteNumero(i))
                    return i;
            }
            throw new InvalidOperationException("No hay más dorsales disponibles");
        }
    }
    public bool ExistePersona(PersonaJuego persona)
        => Arquero.EsPersona(persona)
        || Lineas.Any(l => l.ExistePersona(persona))
        || Suplentes.Any(s => s.EsPersona(persona))
        || Reserva.Any(r => r.EsPersona(persona));
    public void AgregarSuplente(PosicionEnCancha futbolista)
        => AgregarSiSePuedeEn(Suplentes, futbolista, CantidadSuplentes);
    public void AgregarReserva(PosicionEnCancha futbolista)
        => AgregarSiSePuedeEn(Reserva, futbolista, CantidadReserva);
    private void AgregarSiSePuedeEn(List<PosicionEnCancha> lista, PosicionEnCancha pec, byte tope)
    {
        if (lista.Count < tope)
        {
            if (!pec.HayJugador)
                throw new ArgumentNullException("La posicion no tiene Persona");
            if (ExistePersona(pec.Persona!))
                throw new InvalidOperationException(_jugadorYaExiste);
            lista.Add(pec);
        }
        else
            throw new InvalidOperationException(_posicionesLlenas);
    }
}
