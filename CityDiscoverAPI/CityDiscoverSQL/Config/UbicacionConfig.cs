using CityDiscoverSQL.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityDiscoverSQL.Config
{
    public class UbicacionConfig : IEntityTypeConfiguration<UbicacionEntidad>
    {
        public void Configure(EntityTypeBuilder<UbicacionEntidad> builder)
        {
            builder.ToTable(nameof(UbicacionEntidad));
            builder.HasKey(c => c.IdUbicacion);

            builder
                .HasMany<FotoAnexadaEntidad>(oRow => oRow.FotoAnexadas)
                .WithOne(oItem => oItem.Ubicacion)
                .HasForeignKey(c => c.IdUbicacion);
        }
    }
}
