namespace Fulbo12.Core.Fixtures;
public class PersonasFixture
{
    public PersonaJuego PLioMessi { get; set; }
    public PersonaJuego PFrankFabra { get; set; }
    public PersonaJuego PMarcosRojo { get; set; }
    public PersonaJuego PEsequielBarco { get; set; }
    public PersonaJuego PBrunoZuculini { get; set; }
    public PersonaJuego PAgustinPalavecino { get; set; }
    public PersonaJuego PJuanferQuintero { get; set; }
    public PersonaJuego PNicoDeLaCruz { get; set; }
    public PersonaJuego PEnzoFernandez { get; set; }
    public PersonaJuego PEnzoPerez { get; set; }
    public PersonaJuego PJoseParadela { get; set; }
    public PersonaJuego PFelipePenaBiafore { get; set; }
    public PersonaJuego PSantiagoSimon { get; set; }
    public PersonaJuego PTomasPochettino { get; set; }
    public PersonaJuego PBraianRomero { get; set; }
    public PersonaJuego PFlabianLondono { get; set; }
    public PersonaJuego PJulianAlvarez { get; set; }
    public PersonaJuego PMatiasSuarez { get; set; }
    public PersonaJuego PRobertRojas { get; set; }
    public PersonaJuego PJonatanMaidana { get; set; }
    public PersonaJuego PDavidMartinez { get; set; }
    public PersonaJuego PLeanGonzalesPirez { get; set; }
    public PersonaJuego PMarceAndresHerrera { get; set; }
    public PersonaJuego PPauloDiaz { get; set; }
    public PersonaJuego PMiltonCasco { get; set; }
    public PersonaJuego PJavierPinola { get; set; }
    public PersonaJuego PEmanuelMammana { get; set; }
    public PersonaJuego PEliasGomez { get; set; }
    public PersonaJuego PFrancoArmani { get; set; }
    public PersonaJuego PEzequielCenturion { get; set; }
    public PersonaJuego PFrancoPetroli { get; set; }
    public PersonaJuego PFMarceloWeigandt { get; private set; }

    public PersonasFixture(PaisesFixtures paisesFixtures)
    {
        PFMarceloWeigandt = new PersonaJuego()
        {
            Nombre = "Marcelo",
            Apellido = "Weigandt",
            Pais = paisesFixtures.Argentina,
            Altura = 1.75f,
            Peso = 75
        };

        PLioMessi = new PersonaJuego()
        {
            Nombre = "Lionel",
            Apellido = "Messi",
            Pais = paisesFixtures.Argentina,
            Altura = 1.7f,
            Peso = 81
        };

        PFrankFabra = new PersonaJuego()
        {
            Nombre = "Frank",
            Apellido = "Fabra",
            Pais = paisesFixtures.Colombia,
            Altura = 1.74f,
            Peso = 80
        };

        PMarcosRojo = new PersonaJuego()
        {
            Nombre = "Marcos",
            Apellido = "Rojo",
            Pais = paisesFixtures.Argentina,
            Altura = 1.87f,
            Peso = 82
        };

        PEsequielBarco = new PersonaJuego()
        {
            Nombre = "Esequiel",
            Apellido = "Barco",
            Pais = paisesFixtures.Argentina,
            Altura = 1.67f,
            Peso = 65
        };

        PBrunoZuculini = new PersonaJuego()
        {
            Nombre = "Bruno",
            Apellido = "Zuculini",
            Pais = paisesFixtures.Argentina,
            Altura = 1.82f,
            Peso = 77
        };

        PAgustinPalavecino = new PersonaJuego()
        {
            Nombre = "Agustin",
            Apellido = "Palavecino",
            Pais = paisesFixtures.Argentina,
            Altura = 1.79f,
            Peso = 74
        };

        PJuanferQuintero = new PersonaJuego()
        {
            Nombre = "Juan Fernando",
            Apellido = "Quintero",
            Pais = paisesFixtures.Colombia,
            Altura = 1.68f,
            Peso = 67
        };

        PNicoDeLaCruz = new PersonaJuego()
        {
            Nombre = "Nicolas",
            Apellido = "De La Cruz",
            Pais = paisesFixtures.Uruguay,
            Altura = 1.67f,
            Peso = 65
        };

        PEnzoFernandez = new PersonaJuego()
        {
            Nombre = "Enzo",
            Apellido = "Fernandez",
            Pais = paisesFixtures.Argentina,
            Altura = 1.80f,
            Peso = 77
        };

        PEnzoPerez = new PersonaJuego()
        {
            Nombre = "Enzo",
            Apellido = "Perez",
            Pais = paisesFixtures.Argentina,
            Altura = 1.78f,
            Peso = 77
        };

        PJoseParadela = new PersonaJuego()
        {
            Nombre = "Jose",
            Apellido = "Paradela",
            Pais = paisesFixtures.Argentina,
            Altura = 1.79f,
            Peso = 71
        };

        PFelipePenaBiafore = new PersonaJuego()
        {
            Nombre = "Felipe",
            Apellido = "Peña Biafore",
            Pais = paisesFixtures.Argentina,
            Altura = 1.80f,
            Peso = 75
        };

        PSantiagoSimon = new PersonaJuego()
        {
            Nombre = "Santiago",
            Apellido = "Simon",
            Pais = paisesFixtures.Argentina,
            Altura = 1.81f,
            Peso = 74
        };

        PTomasPochettino = new PersonaJuego()
        {
            Nombre = "Tomas",
            Apellido = "Pochettino",
            Pais = paisesFixtures.Argentina,
            Altura = 1.80f,
            Peso = 72
        };

        PBraianRomero = new PersonaJuego()
        {
            Nombre = "Braian",
            Apellido = "Romero",
            Pais = paisesFixtures.Argentina,
            Altura = 1.76f,
            Peso = 73
        };

        PFlabianLondono = new PersonaJuego()
        {
            Nombre = "Flabian",
            Apellido = "Londoño",
            Pais = paisesFixtures.Colombia,
            Altura = 1.80f,
            Peso = 82
        };

        PJulianAlvarez = new PersonaJuego()
        {
            Nombre = "Julian",
            Apellido = "Alvarez",
            Pais = paisesFixtures.Argentina,
            Altura = 1.70f,
            Peso = 71
        };

        PMatiasSuarez = new PersonaJuego()
        {
            Nombre = "Matias",
            Apellido = "Suarez",
            Pais = paisesFixtures.Argentina,
            Altura = 1.83f,
            Peso = 77
        };

        PRobertRojas = new PersonaJuego()
        {
            Nombre = "Robert",
            Apellido = "Rojas",
            Pais = paisesFixtures.Paraguay,
            Altura = 1.76f,
            Peso = 75
        };

        PJonatanMaidana = new PersonaJuego()
        {
            Nombre = "Jonatan",
            Apellido = "Maidana",
            Pais = paisesFixtures.Argentina,
            Altura = 1.85f,
            Peso = 86
        };

        PDavidMartinez = new PersonaJuego()
        {
            Nombre = "David",
            Apellido = "Martinez",
            Pais = paisesFixtures.Argentina,
            Altura = 1.82f,
            Peso = 76
        };

        PLeanGonzalesPirez = new PersonaJuego()
        {
            Nombre = "Leandro",
            Apellido = "Gonzáles Pirez",
            Pais = paisesFixtures.Argentina,
            Altura = 1.85f,
            Peso = 89
        };

        PMarceAndresHerrera = new PersonaJuego()
        {
            Nombre = "Marcelo",
            Apellido = "Andrés Herrera",
            Pais = paisesFixtures.Argentina,
            Altura = 1.78f,
            Peso = 75
        };

        PPauloDiaz = new PersonaJuego()
        {
            Nombre = "Paulo",
            Apellido = "Díaz",
            Pais = paisesFixtures.Argentina,
            Altura = 1.78f,
            Peso = 76
        };

        PMiltonCasco = new PersonaJuego()
        {
            Nombre = "Milton",
            Apellido = "Casco",
            Pais = paisesFixtures.Argentina,
            Altura = 1.70f,
            Peso = 69
        };

        PJavierPinola = new PersonaJuego()
        {
            Nombre = "Javier",
            Apellido = "Pinola",
            Pais = paisesFixtures.Argentina,
            Altura = 1.80f,
            Peso = 79
        };

        PEmanuelMammana = new PersonaJuego()
        {
            Nombre = "Emanuel",
            Apellido = "Mammana",
            Pais = paisesFixtures.Argentina,
            Altura = 1.83f,
            Peso = 72
        };

        PEliasGomez = new PersonaJuego()
        {
            Nombre = "Elías",
            Apellido = "Gómez",
            Pais = paisesFixtures.Argentina,
            Altura = 1.75f,
            Peso = 79
        };

        PFrancoArmani = new PersonaJuego()
        {
            Nombre = "Franco",
            Apellido = "Armani",
            Pais = paisesFixtures.Argentina,
            Altura = 1.89f,
            Peso = 88
        };

        PEzequielCenturion = new PersonaJuego()
        {
            Nombre = "Ezequiel",
            Apellido = "Centurón",
            Pais = paisesFixtures.Argentina,
            Altura = 1.84f,
            Peso = 79
        };

        PFrancoPetroli = new PersonaJuego()
        {
            Nombre = "Franco",
            Apellido = "Petrolito",
            Pais = paisesFixtures.Argentina,
            Altura = 1.87f,
            Peso = 85
        };
    }
}