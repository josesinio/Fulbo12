using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Formacion
{
    public class FormacionBuilder
    {
        public Formacion formacion { get; private set; }
        private Linea linea { get; set; }
        public FormacionBuilder()
        {
            formacion = new Formacion();
            linea = new Linea();
        }
        public FormacionBuilder AgregarLinea(Linea linea)
        {
            this.linea = linea;
            formacion.Lineas.Add(linea);
            return this;
        }
        public FormacionBuilder AgregarPosicion(Futbolista futbolista, Posicion posicion, byte? nro = null)
        {
            var posicionEnCancha = new PosicionEnCancha()
            {
                Futbolista = futbolista,
                Posicion = posicion,
                NumeroCamiseta = nro ?? formacion.NumeroDisponible
            };
            linea.Posiciones.Add(posicionEnCancha);
            return AgregarPosicion(posicionEnCancha);
        }
        public FormacionBuilder AgregarPosicion(PosicionEnCancha posicionEnCancha)
        {
            posicionEnCancha.NumeroCamiseta ??= formacion.NumeroDisponible;
            linea.Posiciones.Add(posicionEnCancha);
            return this;
        }
    }
}