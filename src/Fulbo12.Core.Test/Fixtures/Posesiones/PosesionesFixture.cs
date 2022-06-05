using Fulbo12.Core.Futbol.Fixtures;

namespace Fulbo12.Core.Posesiones.Fixtures;
public class PosesionesFixture
{
    public UsuariosFixture Usuarios { get; set; }
    public FutbolistasFixture Futbolistas { get; set; }
    public PosesionesFixture()
    {
        Usuarios = new UsuariosFixture();
        Futbolistas = new FutbolFixture().Futbolistas;
    }
    public void BlanquearUsuario(Usuario usuario)
    {
        usuario.Posesiones.Clear();
        usuario.NuevasPosesiones.Clear();
        usuario.Transferibles.Clear();
        usuario.Publicaciones.Clear();
        usuario.Debitar(usuario.Monedas);
    }
}