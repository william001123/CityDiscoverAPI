using CityDiscoverSQL.Config;
using CityDiscoverSQL.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverSQL.Contextos
{
    public class CityDiscoverContexto : DbContext
    {

        public DbSet<AutenticacionEntidad> AutenticacionEntidad { get; set; }
        public DbSet<FotoAnexadaEntidad> FotoAnexadaEntidad { get; set; }
        public DbSet<Rol_AutenticacionEntidad> Rol_AutenticacionEntidad { get; set; }
        public DbSet<RolEntidad> RolEntidad { get; set; }
        public DbSet<TipoLugarEntidad> TipoLugarEntidad { get; set; }
        public DbSet<UbicacionEntidad> UbicacionEntidad { get; set; }

        public CityDiscoverContexto() { }

        public CityDiscoverContexto(DbContextOptions<CityDiscoverContexto> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true);
            //IConfigurationRoot root = builder.Build();

            //optionsBuilder.UseSqlServer(root["ConnectionStrings:Financiero"]);

            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-TRD41NTA;Initial Catalog=dbCityDiscover;Integrated Security=true;Trust Server Certificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AutenticacionConfig());
            modelBuilder.ApplyConfiguration(new FotoAnexadaConfig());
            modelBuilder.ApplyConfiguration(new Rol_AutenticacionConfig());
            modelBuilder.ApplyConfiguration(new RolConfig());
            modelBuilder.ApplyConfiguration(new TipoLugarConfig());
            modelBuilder.ApplyConfiguration(new UbicacionConfig());
        }

    }
}
