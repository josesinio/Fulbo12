using Fulbo12.Core.Persistencia.EFC.Mapeos;
using Microsoft.Extensions.Configuration;

namespace Fulbo12.Core.Persistencia.EFC;
public sealed class Fulbo12Contexto : DbContext
{
    public DbSet<Pais> Paises { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.ApplyConfiguration<Pais>(new MapPais());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder ob)
    {
        if (!ob.IsConfigured)
        {
            var serverVersion = new MySqlServerVersion("8.0.29");
            ob.UseMySql(serverVersion);
        }
    }
}