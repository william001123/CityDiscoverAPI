using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDiscoverSQL.Entidades
{
    public class TipoLugarEntidad
    {
        [Key]
        [Required]
        public int IdTipoLugar { get; set; }

        [StringLength(30)]
        public string? strNombre { get; set; }

        public IList<UbicacionEntidad>? Ubicacions { get; set; }
    }
}
