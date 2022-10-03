namespace Fulbo12.Core.Posesiones;
public class Publicacion
{
    public static readonly byte MaximoDias = 5;
    public Posesion Posesion { get; init; }
    public DateTime Inicio { get; init; }
    public DateTime Fin => Inicio.AddDays(Dias);
    public byte Dias { get; init; }
    public uint OfertaMinima { get; init; }
    public uint Compra { get; init; }
    public Usuario Ofertante { get; set; }
    public uint? Oferta { get; set; }
    public uint OfertaOMinima => Oferta ?? OfertaMinima;
    public readonly string msjMaxDias = $"No pueden ser más de {MaximoDias} días";
    public bool HayOfertante => Ofertante is not null;                      
    public Publicacion(Posesion posesion)
    {
        Posesion = posesion;
        Inicio = DateTime.Now;
        Ofertante = null;
        Oferta = null;
    }
    public Publicacion(Posesion posesion, uint minima, uint compra, byte dias) : this(posesion)
    {
        if (dias > MaximoDias)
            throw new ArgumentOutOfRangeException(msjMaxDias);
        OfertaMinima = minima;
        Compra = compra;
        Dias = dias;
    }
    public bool EsVendedor(Usuario usuario) => Posesion.Usuario == usuario;
    public bool CantidadEsMayorOIgual(uint oferta)
        => Oferta.HasValue ? oferta > Oferta.Value : oferta >= OfertaMinima;
    public void RecibirOferta(Usuario usuario, uint oferta)
    {
        if (CantidadEsMayorOIgual(oferta))
        {
            BajarOfertanteAntiguo();
            RegistrarOfertante(usuario, oferta);
        }
    }
    private void RegistrarOfertante(Usuario usuario, uint oferta)
    {
        Oferta = oferta;
        Ofertante = usuario;
    }
    private void BajarOfertanteAntiguo()
    {
        if (HayOfertante)
            Ofertante.SacarOferta(this);
    }
    public void Aplicar()
    {
        var vendedor = Posesion.Usuario;

        vendedor.BajarPublicacion(this);
        if (HayOfertante)
        {
            Posesion.Reiniciar();
            vendedor.Acreditar(Oferta.Value);
            Posesion.Usuario = Ofertante;
            Ofertante.AgregarNovedad(Posesion);
        }
        else
        {
            vendedor.AgregarNovedad(Posesion);
            vendedor.AgregarTransferible(Posesion);
        }
    }
}