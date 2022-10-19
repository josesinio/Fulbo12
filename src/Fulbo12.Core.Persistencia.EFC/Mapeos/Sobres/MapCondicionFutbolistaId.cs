using Fulbo12.Core.Futbol;
using Fulbo12.Core.Sobres.Condiciones;

namespace Fulbo12.Core.Persistencia.EFC.Mapeos.Sobres;

public class MapCondicionFutbolistaId : IEntityTypeConfiguration<CondicionFutbolistaEspecifico>
{
    public void Configure(EntityTypeBuilder<CondicionFutbolistaEspecifico> etb)
    {
        etb.Property(cfe => cfe.IdFutbolista)
            .HasColumnName("idFutbolista");

        etb.HasOne<Futbolista>()
            .WithMany()
            .HasForeignKey(efc => efc.IdFutbolista)
            .HasConstraintName("FK_Componente_Futbolista");

    }
}