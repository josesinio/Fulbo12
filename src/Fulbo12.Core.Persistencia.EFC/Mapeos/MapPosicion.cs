using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.EFC.Mapeos;
public class MapPosicion : IEntityTypeConfiguration<Posicion>
{
    public void Configure(EntityTypeBuilder<Posicion> etb)
    {
        etb.ToTable("Posicion");

        etb.HasKey(p => p.Id)
            .HasName("Pk_Posicion");

        etb.Property(p => p.Id)
            .HasColumnName("idPosicion");
        
        etb.Property(p => p.Nombre)
            .HasColumnName("posicion")
            .IsRequired()
            .HasMaxLength(30);

        etb.Property(p => p.Abreviado)
            .HasColumnName("abreviado")
            .IsFixedLength()
            .IsRequired()
            .HasMaxLength(3);

        etb.HasIndex(p => p.Nombre)
            .HasDatabaseName("UQ_Posicion_posicion")
            .IsUnique();

        etb.HasIndex(p => p.Abreviado)
            .HasDatabaseName("UQ_Posicion_abreviado")
            .IsUnique();
    }
}
