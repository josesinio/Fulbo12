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

        etb.HasData(InstanciarPosiciones());
    }

    private List<Posicion> InstanciarPosiciones()
        => new List<Posicion>()
        {
            new Posicion(1, "Arquero", "ARQ"),
            new Posicion(2, "Lateral Derecho", "LD"),
            new Posicion(3, "Defensor Central", "DFC"),
            new Posicion(4, "Lateral Izquierdo", "LI"),
            new Posicion(5, "Carrilero Derecho", "CAD"),
            new Posicion(6, "Carrilero Izquierdo", "CAI"),
            new Posicion(7, "Mediocampista Defensivo", "MCD"),
            new Posicion(8, "Mediocampista Derecho", "MD"),
            new Posicion(9, "Mediocampista", "MC"),
            new Posicion(10, "Mediocampista Izquierdo", "MI"),
            new Posicion(11, "Mediocampista Ofensivo", "MCO"),
            new Posicion(12, "Media Punta", "MP"),
            new Posicion(13, "Segundo Delantero Derecho", "SDD"),
            new Posicion(14, "Segundo Delantero Izquierdo", "SDI"),
            new Posicion(15, "Extremo Derecho", "ED"),
            new Posicion(16, "Delantero Centro", "DC"),
            new Posicion(17, "Extremo Izquierdo", "EI")
        };
}
