
namespace CityDiscoverDTO.DTOs
{
    public class clsUbicacionDTO
    {
        public int IdUbicacion { get; set; }

        public double? numLatitud { get; set; }

        public double? numLongitud { get; set; }

        public string? strNombre { get; set; }

        public string? strDescripcion { get; set; }

        public int IdTipoLugar { get; set; }
    }
}
