using Fulbo12.Core.Futbol;
namespace Fulbo12.Core.Persistencia.EFC.Mapeos;
public class MapFutbolista : IEntityTypeConfiguration<Futbolista>
{
    public void Configure(EntityTypeBuilder<Futbolista> etb)
    {
        etb.ToTable("Futbolista");

        etb.HasKey(f => f.Id)
            .HasName("Pk_Futbolista");
        etb.Property(p => p.Id)
            .HasColumnName("idFutbolista")
            .ValueGeneratedOnAdd();

        etb.HasOne(f => f.Persona)
            .WithMany()
            .HasForeignKey("idPersona")
            .IsRequired()
            .HasConstraintName("FK_Futbolista_Persona");

        etb.HasOne(f => f.Equipo)
            .WithMany(e => e.Futbolistas)
            .HasForeignKey("idEquipo")
            .IsRequired()
            .HasConstraintName("FK_Futbolista_Equipo");

        etb.HasMany(f => f.Posiciones)
            .WithMany(p => p.Futbolistas)
            //.UsingEntity(j=>j.ToTable("FutbolistaPosicion"));
            .UsingEntity<Dictionary<string, object>>("FutbolistaPosicion",
                j => j
                    .HasOne<Posicion>()
                    .WithMany()
                    .HasForeignKey("idPosicion")
                    .HasConstraintName("FK_FutbolistaPosicion_Posicion"),
                j => j
                    .HasOne<Futbolista>()
                    .WithMany()
                    .HasForeignKey("idFutbolista")
                    .HasConstraintName("FK_FutbolistaPosicion_Futbolista")
                    );

    }
}
