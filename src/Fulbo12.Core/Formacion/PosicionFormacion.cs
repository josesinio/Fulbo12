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
    public int IdFormacion { get; set; }
    public Futbolista Futbolista { get; set; }
    public byte NumCamiseta { get; set; }
    public byte NroAlineacion { get; set; }
    public float SuperiorY { get; set; }
    public float SuperiorX { get; set; }
    public float Ancho { get; set; }
    public float Largo { get; set; }
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

    private void InstanciarArea()
        => Area = new RectangleF( SuperiorX,SuperiorY, Ancho, Largo);

    public PointF PuntoMedio
        => new PointF(Area.Location.X - Ancho + SuperiorX / 2, Area.Location.Y - Ancho + DerechaSuperior / 2);
}
