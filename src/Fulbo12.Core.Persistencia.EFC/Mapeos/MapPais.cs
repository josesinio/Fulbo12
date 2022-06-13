namespace Fulbo12.Core.Persistencia.EFC.Mapeos;
public class MapPais : IEntityTypeConfiguration<Pais>
{
    public void Configure(EntityTypeBuilder<Pais> builder)
    {
        builder.ToTable("Pais");

        builder.HasKey(p => p.Id)
            .HasName("PK_Pais");
        builder.Property(p => p.Id)
            .HasColumnName("idPais");

        builder.Property(p => p.Nombre)
            .HasColumnName("pais");
        builder.HasIndex(p => p.Nombre)
            .HasDatabaseName("UQ_Pais_pais")
            .IsUnique();
    }
}