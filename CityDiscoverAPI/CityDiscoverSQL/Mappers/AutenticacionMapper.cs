using CityDiscoverSQL.Entidades;
using CityDiscoverDom.Modelos;

namespace CityDiscoverSQL.Mappers
{
    public static class AutenticacionMapper
    {
        public static AutenticacionEntidad Map(this clsAutenticacionModelo model)
        {
            return new AutenticacionEntidad()
            {
                Usuario = model.Usuario,
                Contrasena = model.Contrasena
            };
        }

        public static List<AutenticacionEntidad> Map(this List<clsAutenticacionModelo> model)
        {
            List<AutenticacionEntidad> Dtos = new List<AutenticacionEntidad>();

            foreach (clsAutenticacionModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static List<clsAutenticacionModelo> Map(this List<AutenticacionEntidad> model)
        {
            List<clsAutenticacionModelo> Dtos = new List<clsAutenticacionModelo>();

            foreach (AutenticacionEntidad modelItem in model)
            {
                Dtos.Add(Map(modelItem));
                //clienteDtos.Add(new ClienteDto(modelItem.strNumeroIdentificacion));
            }

            return Dtos;
        }

        public static clsAutenticacionModelo Map(this AutenticacionEntidad DTO)
        {
            return new clsAutenticacionModelo()
            {
                Usuario = DTO.Usuario,
                Contrasena = DTO.Contrasena
            };
        }
    }
}
