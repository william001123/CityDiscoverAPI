using CityDiscoverSQL.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityDiscoverSQL.Config
{
    public class AutenticacionConfig : IEntityTypeConfiguration<AutenticacionEntidad>
    {
        public void Configure(EntityTypeBuilder<AutenticacionEntidad> builder)
        {
            builder.ToTable(nameof(AutenticacionEntidad));
            builder.HasKey(c => c.Usuario);
        }
    }
}
