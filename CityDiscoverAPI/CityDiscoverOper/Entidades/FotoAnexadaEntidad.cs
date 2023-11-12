using System.ComponentModel.DataAnnotations;

namespace CityDiscoverOper.Entidades
{
    public class FotoAnexadaEntidad
    {
        [Key]
        [Required]
        public int IdFotoAnexada { get; set; }

        [Required]
        public int IdUbicacion { get; set; }

        public byte[]? bnImagen { get; set; }

        public UbicacionEntidad? Ubicacion { get; set; }
    }
}
