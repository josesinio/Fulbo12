using System;

namespace Fulbo12.Core.Posesiones
{
    public class Publicacion
    {
        public Posesion Posesion { get; init; }
        public DateTime Inicio { get; init; }
        public uint OfertaMinima { get; init; }
        public uint Compra { get; init; }
        public Usuario Ofertante { get; set; }
        public uint? Oferta { get; set; }
        public uint OfertaOMinima => Oferta ?? OfertaMinima;
        public Publicacion(Posesion posesion)
        {
            Posesion = posesion;
            Inicio = DateTime.Now;
            Ofertante = null;
            Oferta = null;            
        }
        public Publicacion(Posesion posesion, uint minima, uint compra):this(posesion)
        {
            OfertaMinima = minima;
            Compra = compra;
        }
        public bool EsVendedor(Usuario usuario) => Posesion.Usuario == usuario;

        public void RecibirOferta(Usuario usuario, uint oferta)
        {
            if (Ofertante is not null)
                Ofertante.SacarOferta(this);
            Oferta = oferta;
            Ofertante = usuario;
        }
        public void Aplicar()
        {
            var vendedor = Posesion.Usuario;

            vendedor.BajarPublicacion(this);
            if (Ofertante is not null)
            {
                Posesion.Reiniciar();
                vendedor.Acreditar(OfertaOMinima);
                Posesion.Usuario = Ofertante;
            }
            vendedor.AgregarNovedad(Posesion);
        }
    }
}