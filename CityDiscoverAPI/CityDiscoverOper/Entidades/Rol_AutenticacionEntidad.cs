using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityDiscoverOper.Entidades
{
    public class Rol_AutenticacionEntidad
    {
        [Required]
        [ForeignKey("RolEntidad"), Column(Order = 0)]
        public int IdRol { get; set; }

        [ForeignKey("AutenticacionEntidad"), Column(Order = 1)]
        [StringLength(10)]
        public string? Usuario { get; set; }

        public RolEntidad? Rol { get; set; }

        public AutenticacionEntidad? Autenticacion { get; set; }
    }
}
