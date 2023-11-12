using CityDiscoverDom.Modelos;
using CityDiscoverDTO.DTOs;

namespace CityDiscoverDTO.Mappers
{
    public static class clsRol_AutenticacionMapper
    {
        public static clsRol_AutenticacionModelo Map(this clsRol_AutenticacionDTO model)
        {
            return new clsRol_AutenticacionModelo()
            {
                IdRol = model.IdRol,
                Usuario= model.Usuario
            };
        }

        public static List<clsRol_AutenticacionModelo> Map(this List<clsRol_AutenticacionDTO> model)
        {
            List<clsRol_AutenticacionModelo> Dtos = new List<clsRol_AutenticacionModelo>();

            foreach (clsRol_AutenticacionDTO modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsRol_AutenticacionDTO> Map(this List<clsRol_AutenticacionModelo> model)
        {
            List<clsRol_AutenticacionDTO> Dtos = new List<clsRol_AutenticacionDTO>();

            foreach (clsRol_AutenticacionModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsRol_AutenticacionDTO Map(this clsRol_AutenticacionModelo DTO)
        {
            return new clsRol_AutenticacionDTO()
            {
                IdRol = DTO.IdRol,
                Usuario = DTO.Usuario
            };
        }
    }
}
