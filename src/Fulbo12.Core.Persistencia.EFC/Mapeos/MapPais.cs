namespace Fulbo12.Core.Persistencia.EFC.Mapeos;
public class MapPais : IEntityTypeConfiguration<Pais>
{
    public static readonly byte IdArgentina = 1;
    public void Configure(EntityTypeBuilder<Pais> etb)
    {
        etb.ToTable("Pais");

        etb.HasKey(p => p.Id)
            .HasName("PK_Pais");
        etb.Property(p => p.Id)
            .HasColumnName("idPais");

        etb.Property(p => p.Nombre)
            .HasColumnName("pais");
        etb.HasIndex(p => p.Nombre)
            .HasDatabaseName("UQ_Pais_pais")
            .IsUnique();
        
        etb.Property(p=>p.Abreviatura)
        .HasColumnName("abreviatura")
        .IsFixedLength()
        .HasMaxLength(2);

        etb.HasData(new Pais(IdArgentina, "Argentina", "ar"));
    }
}