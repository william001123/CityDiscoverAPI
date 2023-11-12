using System.ComponentModel.DataAnnotations;

namespace CityDiscoverSQL.Entidades
{
    public class AutenticacionEntidad
    {
        [StringLength(10)]
        [Key]
        public string? Usuario { get; set; }

        public string? Contrasena { get; set; }

        public IList<Rol_AutenticacionEntidad>? Rol_Autenticacions { get; set; }
    }
}
