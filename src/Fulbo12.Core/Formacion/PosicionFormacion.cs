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
    public byte NumCamiseta { get; set; }
    public byte NroAlineacion { get; set; }
    public float DerechaSuperior { get; set; }
    public float IzquierdaSuperior { get; set; }

    public float DerechaInferior {get; set;}
    public float Izquierdainferior {get; set;}

    [NotMapped]
    public PointF Coordenada { get; set; }

    [NotMapped]
    public RectangleF Area { get; set; }

    public PosicionFormacion(int Idformacion, byte numCamiseta,  byte nroAlineacion, float derechaSuperior, float izquierdaSuperior, float derechaInferior, float izquierdaInferior)
    {
        IdFormacion = Idformacion;
        NumCamiseta = numCamiseta;
        NroAlineacion = nroAlineacion;
        DerechaSuperior = derechaSuperior;
        IzquierdaSuperior = izquierdaSuperior;
        DerechaInferior = derechaInferior;
        Izquierdainferior = izquierdaInferior;
        InstanciarArea();
    }

    private void InstanciarArea()
        =>  Area = new RectangleF(DerechaSuperior,IzquierdaSuperior, DerechaInferior, Izquierdainferior);

    public PointF PuntoMedio
        => new PointF(Area.Location.X - DerechaInferior + IzquierdaSuperior / 2, Area.Location.Y - DerechaInferior + IzquierdaSuperior / 2);
}
