using Fulbo12.Core.Futbol;

namespace Fulbo12.Core.Persistencia.EFC.Mapeos;
public class MapTipoFutbolista : IEntityTypeConfiguration<TipoFutbolista>
{
    public void Configure(EntityTypeBuilder<TipoFutbolista> etb)
    {
        etb.ToTable("TipoFutbolista");

        etb.HasKey(tf => tf.Id)
            .HasName("PK_TipoFutbolista_idTipoFutbolista");

        etb.Property(tf => tf.Id)
            .HasColumnName("idTipoFutbolista")
            .ValueGeneratedOnAdd();

        etb.Property(tf => tf.Nombre)
            .HasColumnName("nombre")
            .IsRequired();

        etb.Property(tf => tf.Especial)
            .HasColumnName("especial")
            .IsRequired();

        etb.HasIndex(tf => tf.Nombre)
            .IsUnique()
            .HasDatabaseName("UQ_TipoFutbolista_nombre");

        var bronceComun = new TipoFutbolista("Bronce Común") { Id = 1, Especial = false };
        var bronceEspecial = new TipoFutbolista("Bronce Especial") { Id = 2, Especial = true };
        var plataComun = new TipoFutbolista("Plata Común") { Id = 3, Especial = false };
        var plataEspecial = new TipoFutbolista("Plata Especial") { Id = 4, Especial = true };
        var oroComun = new TipoFutbolista("Oro Común") { Id = 5, Especial = false };
        var oroEspecial = new TipoFutbolista("Oro Especial") { Id = 6, Especial = true };

        etb.HasData(bronceComun, bronceEspecial, plataComun, plataEspecial,
                    oroComun, oroEspecial);
    }
}