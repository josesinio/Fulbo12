using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Persistencia.EFC.Mapeos;
public class MapLiga : IEntityTypeConfiguration<Liga>
{
    public static readonly byte IdSuperLiga = 1;
    public static readonly byte IdLigaEt12 = 2;
    public void Configure(EntityTypeBuilder<Liga> etb)
    {
        etb.ToTable("Liga");

        etb.HasKey(l => l.Id)
            .HasName("Pk_Liga");
        etb.Property(p => p.Id)
            .HasColumnName("idLiga");

        etb.Property(l => l.Nombre)
            .HasColumnName("nombre")
            .IsRequired()
            .HasMaxLength(30);

        etb.HasOne(l => l.Pais)
            .WithMany()
            .HasForeignKey("idPais")
            .IsRequired()
            .HasConstraintName("FK_Liga_Pais");

        etb.HasIndex(l => l.Nombre)
            .HasDatabaseName("UQ_Liga_nombre")
            .IsUnique();

        etb.HasData(
            new { Id = IdSuperLiga, idPais = MapPais.IdArgentina, Nombre = "SuperLiga" },
            new { Id = IdLigaEt12, idPais = MapPais.IdArgentina, Nombre = "Liga ET12" }
            );
    }
}