using CityDiscoverOper.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityDiscoverOper.Config
{
    public class RolConfig : IEntityTypeConfiguration<RolEntidad>
    {
        public void Configure(EntityTypeBuilder<RolEntidad> builder)
        {
            builder.ToTable(nameof(RolEntidad));
            builder.HasKey(c => c.IdRol);
        }
    }
}
