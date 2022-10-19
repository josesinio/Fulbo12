using Fulbo12.Core.Sobres;
using Fulbo12.Core.Sobres.Compuestos;
using Fulbo12.Core.Sobres.Condiciones;

namespace Fulbo12.Core.Persistencia.EFC.Mapeos.Sobres;
public class MapComponenteSobre : IEntityTypeConfiguration<ComponenteSobre>
{
    public void Configure(EntityTypeBuilder<ComponenteSobre> etb)
    {
        etb.ToTable("ComponenteSobre");

        etb.HasKey(c => c.Id)
            .HasName("PK_Componente");
        etb.Property(p => p.IdSobre)
            .HasColumnName("idSobre");
        etb.Property(p => p.Id)
            .HasColumnName("idComponente");

        etb.Property<string>("tipo")
            .HasColumnName("tipo")
            .HasMaxLength(20);
        
        etb.Property(c=>c.Cantidad)
            .HasColumnName("cantidad")
            .IsRequired(false);
        
        etb.HasIndex(c => new { c.IdSobre, c.Id })
            .IsUnique()
            .HasDatabaseName("UQ_Componente_IdSobre_IdComponente");        
        
        etb.Ignore(c=>c.Expresion);

        etb.HasDiscriminator<string>("tipo")
            .HasValue<CondicionFutbolistaEspecifico>("FutbolistaEspecifico")
            .HasValue<CompuestoAnd>("And");
    }
}
