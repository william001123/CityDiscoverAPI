using CityDiscoverDom.Modelos;
using CityDiscoverDTO.DTOs;

namespace CityDiscoverDTO.Mappers
{
    public static class clsAutenticacionMapper
    {
        public static clsAutenticacionModelo Map(this clsAutenticacionDTO model)
        {
            return new clsAutenticacionModelo()
            {
                Usuario = model.Usuario,
                Contrasena = model.Contrasena
            };
        }

        public static List<clsAutenticacionModelo> Map(this List<clsAutenticacionDTO> model)
        {
            List<clsAutenticacionModelo> Dtos = new List<clsAutenticacionModelo>();

            foreach (clsAutenticacionDTO modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsAutenticacionDTO> Map(this List<clsAutenticacionModelo> model)
        {
            List<clsAutenticacionDTO> Dtos = new List<clsAutenticacionDTO>();

            foreach (clsAutenticacionModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsAutenticacionDTO Map(this clsAutenticacionModelo DTO)
        {
            return new clsAutenticacionDTO()
            {
                Usuario = DTO.Usuario,
                Contrasena = DTO.Contrasena
            };
        }
    }
}
