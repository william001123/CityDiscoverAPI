using CityDiscoverOper.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityDiscoverOper.Config
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
