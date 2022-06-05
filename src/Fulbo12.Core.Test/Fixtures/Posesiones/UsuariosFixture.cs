namespace Fulbo12.Core.Posesiones.Fixtures;
public class UsuariosFixture
{
    public Usuario Lucho { get; set; }
    public Usuario Arturo { get; set; }
    public UsuariosFixture()
    {
        Lucho = new Usuario("Luis", "Duran",
            nacimiento: new DateTime(2000, 10, 5), @"123@tmail.com");
        Arturo = new Usuario("Arturo", "Cruz",
        nacimiento: new DateTime(1999, 1, 1), @"hola@mimail.com");
    }

}