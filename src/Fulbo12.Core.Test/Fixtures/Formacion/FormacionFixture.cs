namespace Fulbo12.Core.Formacion.Fixtures
{
    public class FormacionFixture
    {
        public PosicionEnCanchaFixture PosicionesEnCancha { get; set; }
        public LineaFixture Lineas {get; set;}
        private FormacionBuilder fb {get; set;}
        public FormacionFixture()
        {
            PosicionesEnCancha = new PosicionEnCanchaFixture ();
            Lineas = new LineaFixture (PosicionesEnCancha);
            fb = new FormacionBuilder();
        }
        public Formacion CrearFormacion()
        {
            var futbolistas = PosicionesEnCancha.Futbol.Futbolistas;
            var posiciones = PosicionesEnCancha.Futbol.Posiciones;
            return  fb  .IniciarFormacion()
                        .AgregarLinea(Lineas.Defensas)
                        .AgregarLinea()
                            .AgregarPosicion(futbolistas.FEnzoPerez, posiciones.MediocampistaDefensivo, 5)
                        .AgregarLinea()
                            .AgregarPosicion(futbolistas.FSantiagoSimon, posiciones.MediocampistaDerecho, 8)
                            .AgregarPosicion(futbolistas.FEnzoFernandez, posiciones.MedioCentro, 7)
                            .AgregarPosicion(futbolistas.FNicoDeLaCruz, posiciones.MedioCentro, 10)
                            .AgregarPosicion(futbolistas.FEsequielBarco, posiciones.MediocampistaIzquierdo, 11)
                        .AgregarLinea()
                            .AgregarPosicion(futbolistas.FJulianAlvarez, posiciones.DelanteroCentral, 9)
                        .Formacion;
        }

    }
}