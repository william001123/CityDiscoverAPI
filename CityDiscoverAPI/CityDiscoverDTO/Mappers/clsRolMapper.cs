using CityDiscoverDom.Modelos;
using CityDiscoverDTO.DTOs;

namespace CityDiscoverDTO.Mappers
{
    public static class clsRolMapper
    {
        public static clsRolModelo Map(this clsRolDTO model)
        {
            return new clsRolModelo()
            {
                IdRol = model.IdRol,
                strNombre = model.strNombre
            };
        }

        public static List<clsRolModelo> Map(this List<clsRolDTO> model)
        {
            List<clsRolModelo> Dtos = new List<clsRolModelo>();

            foreach (clsRolDTO modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsRolDTO> Map(this List<clsRolModelo> model)
        {
            List<clsRolDTO> Dtos = new List<clsRolDTO>();

            foreach (clsRolModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsRolDTO Map(this clsRolModelo DTO)
        {
            return new clsRolDTO()
            {
                IdRol = DTO.IdRol,
                strNombre = DTO.strNombre
            };
        }
    }
}
