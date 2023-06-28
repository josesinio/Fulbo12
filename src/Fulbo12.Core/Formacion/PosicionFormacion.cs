using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Formacion;

public class PosicionFormacion
{
    public int IdFormacion { get; set; }
    public byte NumCamiseta { get; set; }
    public Futbolista Futbolista { get; set; }
    public byte NroAlineacion { get; set; }
    public float PosicionX { get; set; }
    public float PosicionY { get; set; }
    public float Diagonal { get; set; }
    
    [NotMapped]
    public PointF Coordenada { get; set; }

    [NotMapped]
    public RectangleF Area {get; set;}

    public PosicionFormacion(int Idformacion, byte numCamiseta, Futbolista futbolista, byte nroAlineacion, float posicionX, float posicionY, float diagonal, RectangleF area)
    {
        IdFormacion = Idformacion;
        NumCamiseta = numCamiseta;
        NroAlineacion = nroAlineacion;
        Futbolista = futbolista;
        PosicionX = posicionX;
        PosicionY = posicionY;
        Diagonal = diagonal;
        Area= area;
    }

    public PointF PuntoMedio
        => new PointF(Area.Location.X + PosicionX/2, Area.Location.Y - PosicionY/2);
}
