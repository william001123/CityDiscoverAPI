using CityDiscoverDom.Modelos;
using CityDiscoverDTO.DTOs;

namespace CityDiscoverDTO.Mappers
{
    public static class clsTipoLugarMapper
    {
        public static clsTipoLugarModelo Map(this clsTipoLugarDTO model)
        {
            return new clsTipoLugarModelo()
            {
                IdTipoLugar = model.IdTipoLugar,
                strNombre = model.strNombre
            };
        }

        public static List<clsTipoLugarModelo> Map(this List<clsTipoLugarDTO> model)
        {
            List<clsTipoLugarModelo> Dtos = new List<clsTipoLugarModelo>();

            foreach (clsTipoLugarDTO modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsTipoLugarDTO> Map(this List<clsTipoLugarModelo> model)
        {
            List<clsTipoLugarDTO> Dtos = new List<clsTipoLugarDTO>();

            foreach (clsTipoLugarModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsTipoLugarDTO Map(this clsTipoLugarModelo DTO)
        {
            return new clsTipoLugarDTO()
            {
                IdTipoLugar = DTO.IdTipoLugar,
                strNombre = DTO.strNombre
            };
        }
    }
}
