using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Formacion;

/// <summary>
/// Esta clase es la base para las posiciones en cancha de una Linea.
/// No contiene información sobre que jugadores van a estar.
/// </summary>
public class PosicionFormacion
{
    public required int IdFormacion { get; set; } = 0;
    public required Futbolista Futbolista { get; set; }
    public required byte NumCamiseta { get; set; }
    public required byte NroAlineacion { get; set; }
    public required float SuperiorY { get; set; }
    public required float SuperiorX { get; set; }
    public required float Ancho { get; set; }
    public required float Largo { get; set; }
    public static readonly float LargoCancha = 110f;
    public static readonly float AnchoCancha = 75f;

    [NotMapped]
    public PointF Coordenada { get; set; }

    [NotMapped]
    public RectangleF Area { get; set; }

    public PosicionFormacion(int Idformacion, Futbolista futbolista, byte numCamiseta, byte nroAlineacion, float superiorX, float superiorY, float ancho, float largo)
    {
        IdFormacion = Idformacion;
        Futbolista = futbolista;
        NumCamiseta = numCamiseta;
        NroAlineacion = nroAlineacion;
        SuperiorX = superiorX;
        SuperiorY = superiorY;
        Ancho = ancho;
        Largo = largo;
        InstanciarArea();
    }

    public PosicionFormacion()
    {
    }

    public void InstanciarArea()
        => Area = new RectangleF( SuperiorX,SuperiorY, Ancho, Largo);

    public PointF PuntoMedio
        => new PointF(Area.Location.X - Ancho + SuperiorX / 2, Area.Location.Y - Ancho + SuperiorY / 2);
    public bool TieneA(float x, float y) => Area.Contains(x, y);
    public bool TieneA(PointF punto) => Area.Contains(punto);
}
