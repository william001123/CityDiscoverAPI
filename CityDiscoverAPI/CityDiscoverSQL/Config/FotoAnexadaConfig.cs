using CityDiscoverSQL.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityDiscoverSQL.Config
{
    public class FotoAnexadaConfig : IEntityTypeConfiguration<FotoAnexadaEntidad>
    {
        public void Configure(EntityTypeBuilder<FotoAnexadaEntidad> builder)
        {
            builder.ToTable(nameof(FotoAnexadaEntidad));
            builder.HasKey(c => c.IdFotoAnexada);            
        }
    }
}
