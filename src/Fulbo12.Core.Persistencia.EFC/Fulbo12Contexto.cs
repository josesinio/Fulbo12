using Fulbo12.Core.Futbol;
using Fulbo12.Core.Persistencia.EFC.Mapeos;
using Fulbo12.Core.Persistencia.EFC.Mapeos.Sobres;
using Fulbo12.Core.Sobres;
using Fulbo12.Core.Sobres.Condiciones;
using Microsoft.Extensions.Configuration;

namespace Fulbo12.Core.Persistencia.EFC;
public sealed class Fulbo12Contexto : DbContext
{
    public DbSet<Pais> Paises => Set<Pais>();
    public DbSet<PersonaJuego> Personas => Set<PersonaJuego>();
    public DbSet<Liga> Ligas => Set<Liga>();
    public DbSet<Equipo> Equipos => Set<Equipo>();
    public DbSet<Futbolista> Futbolistas => Set<Futbolista>();
    public DbSet<Posicion> Posiciones => Set<Posicion>();
    public DbSet<Sobre> Sobres => Set<Sobre>();
    public DbSet<ComponenteSobre> ComponenteSobres => Set<ComponenteSobre>();

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.ApplyConfiguration<Pais>(new MapPais());
        mb.ApplyConfiguration<PersonaJuego>(new MapPersonaJuego());
        mb.ApplyConfiguration<Liga>(new MapLiga());
        mb.ApplyConfiguration<Equipo>(new MapEquipo());
        mb.ApplyConfiguration<Posicion>(new MapPosicion());
        mb.ApplyConfiguration<Futbolista>(new MapFutbolista());
        mb.ApplyConfiguration<ComponenteSobre>(new MapComponenteSobre());
        mb.ApplyConfiguration<CondicionFutbolistaEspecifico>(new MapCondicionFutbolistaId());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder ob)
    {
        if (!ob.IsConfigured)
        {
            IConfiguration myConfig = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appSettings.json")
                .Build();

            string strConexion = myConfig.GetConnectionString("dev");
            var serverVersion = new MySqlServerVersion(versionString: myConfig["SerVersion"]);
            ob.UseMySql(strConexion, serverVersion);
        }
    }
}