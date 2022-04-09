namespace Fulbo12.Core.Fixtures
{
    public class PersonasFixture
    {
        public Persona PLioMessi { get; set; }
        public Persona PFrankFabra { get; set; }
        public Persona PMarcosRojo { get; set; }
        public PersonasFixture(PaisesFixtures paisesFixtures)
        {
            PLioMessi = new Persona()
            {
                Nombre = "Lionel",
                Apellido = "Messi",
                Pais = paisesFixtures.Argentina,
                Altura = 1.7f,
                Peso = 67
            };

            PFrankFabra = new Persona()
            {
                Nombre = "Frank",
                Apellido = "Fabra",
                Pais = paisesFixtures.Colombia,
                Altura = 1.74f,
                Peso = 80
            };

            PMarcosRojo = new Persona()
            {
                Nombre = "Marcos",
                Apellido = "Rojo",
                Pais = paisesFixtures.Argentina,
                Altura = 1.87f,
                Peso = 82
            };
        }
    }
}