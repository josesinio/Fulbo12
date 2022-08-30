using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.EFC.Mapeos;
public class MapEquipo : IEntityTypeConfiguration<Equipo>
{
    public static short IdEquipoCompu = 1;
    public void Configure(EntityTypeBuilder<Equipo> etb)
    {
        etb.ToTable("Equipo");

        etb.HasKey(e => e.Id)
            .HasName("Pk_Equipo");
        etb.Property(p => p.Id)
            .HasColumnName("idEquipo")
            .ValueGeneratedOnAdd();

        etb.HasOne(e => e.Liga)
            .WithMany(l => l.Equipos)
            .HasForeignKey("idLiga")
            .IsRequired()
            .HasConstraintName("FK_Equipo_Liga");

        etb.Property(e => e.Nombre)
            .HasColumnName("nombre")
            .IsRequired()
            .HasMaxLength(30);

        //Unico nombre por liga
        etb.HasIndex(nameof(Equipo.Nombre), "idLiga")
            .HasDatabaseName("UQ_Equipo_nombre_liga")
            .IsUnique();

        etb.HasData(
            new { Id = IdEquipoCompu, Nombre = "Computación", idLiga = MapLiga.IdLigaEt12 }
        );
    }
}
