using CityDiscoverOper.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityDiscoverOper.Config
{
    public class Rol_AutenticacionConfig : IEntityTypeConfiguration<Rol_AutenticacionEntidad>
    {
        public void Configure(EntityTypeBuilder<Rol_AutenticacionEntidad> builder)
        {
            builder.ToTable(nameof(Rol_AutenticacionEntidad));
            //builder.HasNoKey();           
            builder.HasKey(x => new { x.Usuario, x.IdRol });

            builder
                .HasOne<AutenticacionEntidad>(oRow => oRow.Autenticacion)
                .WithMany(oItem => oItem.Rol_Autenticacions)
                .HasForeignKey(c => c.Usuario);

            builder
                .HasOne<RolEntidad>(oRow => oRow.Rol)
                .WithMany(oItem => oItem.Rol_Autenticacions)
                .HasForeignKey(c => c.IdRol);

        }
    }
}
