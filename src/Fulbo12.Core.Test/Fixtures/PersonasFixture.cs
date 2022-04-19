namespace Fulbo12.Core.Fixtures
{
    public class PersonasFixture
    {
        public Persona PLioMessi { get; set; }
        public Persona PFrankFabra { get; set; }
        public Persona PMarcosRojo { get; set; }
        public Persona PEsequielBarco { get; set; }
        public Persona PBrunoZuculini { get; set; }
        public Persona PAgustinPalavecino { get; set; }
        public Persona PJuanferQuintero { get; set; }
        public Persona PNicoDeLaCruz { get; set; }
        public Persona PEnzoFernandez { get; set; }
        public Persona PEnzoPerez { get; set; }
        public Persona PJoseParadela { get; set; }
        public Persona PFelipePenaBiafore { get; set; }
        public Persona PSantiagoSimon { get; set; }
        public Persona PTomasPochettino { get; set; }
        public Persona PBraianRomero { get; set; }
        public Persona PFlabianLondono { get; set; }
        public Persona PJulianAlvarez { get; set; }
        public Persona PMatiasSuarez { get; set; }
        public Persona PRobertRojas { get; set; }
        public Persona PJonatanMaidana { get; set; }
        public Persona PDavidMartinez { get; set; }
        public Persona PLeanGonzalesPirez { get; set; }
        public Persona PMarceAndresHerrera { get; set; }
        public Persona PPauloDiaz { get; set; }
        public Persona PMiltonCasco { get; set; }
        public Persona PJavierPinola { get; set; }
        public Persona PEmanuelMammana { get; set; }
        public Persona PEliasGomez { get; set; }
        public Persona PFrancoArmani { get; set; }
        public Persona PEzequielCenturion { get; set; }
        public Persona PFrancoPetroli { get; set; }

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

            PEsequielBarco = new Persona()
            {
                Nombre = "Esequiel",
                Apellido = "Barco",
                Pais = paisesFixtures.Argentina,
                Altura = 1.67f,
                Peso = 65
            };

            PBrunoZuculini = new Persona()
            {
                Nombre = "Bruno",
                Apellido = "Zuculini",
                Pais = paisesFixtures.Argentina,
                Altura = 1.82f,
                Peso = 77
            };

            PAgustinPalavecino = new Persona()
            {
                Nombre = "Agustin",
                Apellido = "Palavecino",
                Pais = paisesFixtures.Argentina,
                Altura = 1.79f,
                Peso = 74
            };

            PJuanferQuintero = new Persona()
            {
                Nombre = "Juan Fernando",
                Apellido = "Quintero",
                Pais = paisesFixtures.Colombia,
                Altura = 1.68f,
                Peso = 67
            };

            PNicoDeLaCruz = new Persona()
            {
                Nombre = "Nicolas",
                Apellido = "De La Cruz",
                Pais = paisesFixtures.Uruguay,
                Altura = 1.67f,
                Peso = 65
            };

            PEnzoFernandez = new Persona()
            {
                Nombre = "Enzo",
                Apellido = "Fernandez",
                Pais = paisesFixtures.Argentina,
                Altura = 1.80f,
                Peso = 77
            };

            PEnzoPerez = new Persona()
            {
                Nombre = "Enzo",
                Apellido = "Perez",
                Pais = paisesFixtures.Argentina,
                Altura = 1.78f,
                Peso = 77
            };

            PJoseParadela = new Persona()
            {
                Nombre = "Jose",
                Apellido = "Paradela",
                Pais = paisesFixtures.Argentina,
                Altura = 1.79f,
                Peso = 71
            };

            PFelipePenaBiafore = new Persona()
            {
                Nombre = "Felipe",
                Apellido = "Peña Biafore",
                Pais = paisesFixtures.Argentina,
                Altura = 1.80f,
                Peso = 75
            };

            PSantiagoSimon = new Persona()
            {
                Nombre = "Santiago",
                Apellido = "Simon",
                Pais = paisesFixtures.Argentina,
                Altura = 1.81f,
                Peso = 74
            };

            PTomasPochettino = new Persona()
            {
                Nombre = "Tomas",
                Apellido = "Pochettino",
                Pais = paisesFixtures.Argentina,
                Altura = 1.80f,
                Peso = 72
            };

            PBraianRomero = new Persona()
            {
                Nombre = "Braian",
                Apellido = "Romero",
                Pais = paisesFixtures.Argentina,
                Altura = 1.76f,
                Peso = 73
            };

            PFlabianLondono = new Persona()
            {
                Nombre = "Flabian",
                Apellido = "Londoño",
                Pais = paisesFixtures.Colombia,
                Altura = 1.80f,
                Peso = 82
            };

            PJulianAlvarez = new Persona()
            {
                Nombre = "Julian",
                Apellido = "Alvarez",
                Pais = paisesFixtures.Argentina,
                Altura = 1.70f,
                Peso = 71
            };

            PMatiasSuarez = new Persona()
            {
                Nombre = "Matias",
                Apellido = "Suarez",
                Pais = paisesFixtures.Argentina,
                Altura = 1.83f,
                Peso = 77
            };

            PRobertRojas = new Persona()
            {
                Nombre = "Robert",
                Apellido = "Rojas",
                Pais = paisesFixtures.Paraguay,
                Altura = 1.76f,
                Peso = 75
            };

            PJonatanMaidana = new Persona()
            {
                Nombre = "Jonatan",
                Apellido = "Maidana",
                Pais = paisesFixtures.Argentina,
                Altura = 1.85f,
                Peso = 86
            };

            PDavidMartinez = new Persona()
            {
                Nombre = "David",
                Apellido = "Martinez",
                Pais = paisesFixtures.Argentina,
                Altura = 1.82f,
                Peso = 76
            };

            PLeanGonzalesPirez = new Persona()
            {
                Nombre = "Leandro",
                Apellido = "Gonzáles Pirez",
                Pais = paisesFixtures.Argentina,
                Altura = 1.85f,
                Peso = 89
            };

            PMarceAndresHerrera = new Persona()
            {
                Nombre = "Marcelo",
                Apellido = "Andrés Herrera",
                Pais = paisesFixtures.Argentina,
                Altura = 1.78f,
                Peso = 75
            };

            PPauloDiaz = new Persona()
            {
                Nombre = "Paulo",
                Apellido = "Díaz",
                Pais = paisesFixtures.Argentina,
                Altura = 1.78f,
                Peso = 76
            };

            PMiltonCasco = new Persona()
            {
                Nombre = "Milton",
                Apellido = "Casco",
                Pais = paisesFixtures.Argentina,
                Altura = 1.70f,
                Peso = 69
            };

            PJavierPinola = new Persona()
            {
                Nombre = "Javier",
                Apellido = "Pinola",
                Pais = paisesFixtures.Argentina,
                Altura = 1.80f,
                Peso = 79
            };

            PEmanuelMammana = new Persona()
            {
                Nombre = "Emanuel",
                Apellido = "Mammana",
                Pais = paisesFixtures.Argentina,
                Altura = 1.83f,
                Peso = 72
            };

            PEliasGomez = new Persona()
            {
                Nombre = "Elías",
                Apellido = "Gómez",
                Pais = paisesFixtures.Argentina,
                Altura = 1.75f,
                Peso = 79
            };

            PFrancoArmani = new Persona()
            {
                Nombre = "Franco",
                Apellido = "Armani",
                Pais = paisesFixtures.Argentina,
                Altura = 1.89f,
                Peso = 88
            };

            PEzequielCenturion = new Persona()
            {
                Nombre = "Ezequiel",
                Apellido = "Centurón",
                Pais = paisesFixtures.Argentina,
                Altura = 1.84f,
                Peso = 79
            };

            PFrancoPetroli = new Persona()
            {
                Nombre = "Franco",
                Apellido = "Petrolito",
                Pais = paisesFixtures.Argentina,
                Altura = 1.87f,
                Peso = 85
            };
        }
    }
}