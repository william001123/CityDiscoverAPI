using CityDiscoverOper.Entidades;
using CityDiscoverDom.Modelos;

namespace CityDiscoverOper.Mappers
{
    public static class UbicacionMapper
    {
        public static UbicacionEntidad Map(this clsUbicacionModelo model)
        {
            return new UbicacionEntidad()
            {
                IdUbicacion = model.IdUbicacion,
                strNombre = model.strNombre,
                IdTipoLugar = model.IdTipoLugar,
                numLatitud = model.numLatitud,
                numLongitud = model.numLongitud,
                strDescripcion = model.strDescripcion
            };
        }

        public static List<UbicacionEntidad> Map(this List<clsUbicacionModelo> model)
        {
            List<UbicacionEntidad> Dtos = new List<UbicacionEntidad>();

            foreach (clsUbicacionModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsUbicacionModelo> Map(this List<UbicacionEntidad> model)
        {
            List<clsUbicacionModelo> Dtos = new List<clsUbicacionModelo>();

            foreach (UbicacionEntidad modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsUbicacionModelo Map(this UbicacionEntidad DTO)
        {
            return new clsUbicacionModelo()
            {
                IdUbicacion = DTO.IdUbicacion,
                strNombre = DTO.strNombre
            };
        }
    }
}
