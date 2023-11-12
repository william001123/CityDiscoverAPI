using CityDiscoverDom.Modelos;
using CityDiscoverDTO.DTOs;

namespace CityDiscoverDTO.Mappers
{
    public static class clsUbicacionMapper
    {
        public static clsUbicacionModelo Map(this clsUbicacionDTO model)
        {
            return new clsUbicacionModelo()
            {
                IdUbicacion = model.IdUbicacion,
                strNombre = model.strNombre,
                IdTipoLugar = model.IdTipoLugar,
                numLatitud = model.numLatitud,
                numLongitud = model.numLongitud,
                strDescripcion = model.strDescripcion
            };
        }

        public static List<clsUbicacionModelo> Map(this List<clsUbicacionDTO> model)
        {
            List<clsUbicacionModelo> Dtos = new List<clsUbicacionModelo>();

            foreach (clsUbicacionDTO modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsUbicacionDTO> Map(this List<clsUbicacionModelo> model)
        {
            List<clsUbicacionDTO> Dtos = new List<clsUbicacionDTO>();

            foreach (clsUbicacionModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsUbicacionDTO Map(this clsUbicacionModelo DTO)
        {
            return new clsUbicacionDTO()
            {
                IdUbicacion = DTO.IdUbicacion,
                strNombre = DTO.strNombre
            };
        }
    }
}
