using CityDiscoverSQL.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityDiscoverSQL.Config
{
    public class TipoLugarConfig : IEntityTypeConfiguration<TipoLugarEntidad>
    {
        public void Configure(EntityTypeBuilder<TipoLugarEntidad> builder)
        {
            builder.ToTable(nameof(TipoLugarEntidad));
            builder.HasKey(c => c.IdTipoLugar);

            builder
                .HasMany<UbicacionEntidad>(oRow => oRow.Ubicacions)
                .WithOne(oItem => oItem.TipoLugar)
                .HasForeignKey(c => c.IdTipoLugar);
        }
    }
}
