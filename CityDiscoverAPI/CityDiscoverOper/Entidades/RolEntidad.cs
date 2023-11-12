using System.ComponentModel.DataAnnotations;

namespace CityDiscoverOper.Entidades
{
    public class RolEntidad
    {
        [Key]
        [Required]
        public int IdRol { get; set; }

        [Required]
        public string? strNombre { get; set; }

        public IList<Rol_AutenticacionEntidad>? Rol_Autenticacions { get; set; }
    }
}
