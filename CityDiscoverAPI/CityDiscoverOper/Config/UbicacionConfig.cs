using CityDiscoverOper.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityDiscoverOper.Config
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
