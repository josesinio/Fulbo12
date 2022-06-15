using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Persistencia.EFC.Mapeos;
public class MapLiga : IEntityTypeConfiguration<Liga>
{
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

        etb.Ignore(l => l.Equipos);
    }
}