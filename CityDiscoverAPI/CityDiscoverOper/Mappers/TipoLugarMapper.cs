using CityDiscoverOper.Entidades;
using CityDiscoverDom.Modelos;

namespace CityDiscoverOper.Mappers
{
    public static class TipoLugarMapper
    {
        public static TipoLugarEntidad Map(this clsTipoLugarModelo model)
        {
            return new TipoLugarEntidad()
            {
                IdTipoLugar = model.IdTipoLugar,
                strNombre = model.strNombre
            };
        }

        public static List<TipoLugarEntidad> Map(this List<clsTipoLugarModelo> model)
        {
            List<TipoLugarEntidad> Dtos = new List<TipoLugarEntidad>();

            foreach (clsTipoLugarModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsTipoLugarModelo> Map(this List<TipoLugarEntidad> model)
        {
            List<clsTipoLugarModelo> Dtos = new List<clsTipoLugarModelo>();

            foreach (TipoLugarEntidad modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsTipoLugarModelo Map(this TipoLugarEntidad DTO)
        {
            return new clsTipoLugarModelo()
            {
                IdTipoLugar = DTO.IdTipoLugar,
                strNombre = DTO.strNombre
            };
        }
    }
}
