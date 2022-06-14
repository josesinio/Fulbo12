namespace Fulbo12.Core.Persistencia.EFC.Mapeos;
public class MapPersona : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> etb)
    {
        etb.ToTable("Persona");

        etb.Property(p => p.Nombre)
            .HasColumnName("nombre")
            .IsRequired()
            .HasMaxLength(30);

        etb.Property(p => p.Apellido)
            .HasColumnName("apellido")
            .IsRequired()
            .HasMaxLength(30);

        etb.HasOne(p => p.Pais)
            .WithMany()
            .HasForeignKey("idPais")
            .IsRequired()
            .HasConstraintName("FK_Persona_Pais");
    }
}