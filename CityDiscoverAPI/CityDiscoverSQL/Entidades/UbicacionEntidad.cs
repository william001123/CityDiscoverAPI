using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverSQL.Entidades
{
    public class UbicacionEntidad
    {
        [Key]
        [Required]
        public int IdUbicacion { get; set; }

        public double? numLatitud { get; set; }

        public double? numLongitud { get; set; }

        [StringLength(100)]
        public string? strNombre { get; set; }

        [StringLength(400)]
        public string? strDescripcion { get; set; }

        [Required]
        public int IdTipoLugar { get; set; }

        public IList<FotoAnexadaEntidad>? FotoAnexadas { get; set; }

        public TipoLugarEntidad? TipoLugar { get; set; }
    }
}
