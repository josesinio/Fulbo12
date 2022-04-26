using System;

namespace Fulbo12.Core.Posesiones.Fixtures
{
    public class UsuariosFixture
    {
        public Usuario Lucho { get; set; }
        public UsuariosFixture()
        {
            Lucho = new Usuario("Luis", "Duran",
                nacimiento: new DateTime(2000, 10, 5), @"123@tmail.com");            
        }
    }
}