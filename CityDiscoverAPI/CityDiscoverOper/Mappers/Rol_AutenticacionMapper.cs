using CityDiscoverOper.Entidades;
using CityDiscoverDom.Modelos;

namespace CityDiscoverOper.Mappers
{
    public static class Rol_AutenticacionMapper
    {
        public static Rol_AutenticacionEntidad Map(this clsRol_AutenticacionModelo model)
        {
            return new Rol_AutenticacionEntidad()
            {
                IdRol = model.IdRol,
                Usuario= model.Usuario
            };
        }

        public static List<Rol_AutenticacionEntidad> Map(this List<clsRol_AutenticacionModelo> model)
        {
            List<Rol_AutenticacionEntidad> Dtos = new List<Rol_AutenticacionEntidad>();

            foreach (clsRol_AutenticacionModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsRol_AutenticacionModelo> Map(this List<Rol_AutenticacionEntidad> model)
        {
            List<clsRol_AutenticacionModelo> Dtos = new List<clsRol_AutenticacionModelo>();

            foreach (Rol_AutenticacionEntidad modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsRol_AutenticacionModelo Map(this Rol_AutenticacionEntidad DTO)
        {
            return new clsRol_AutenticacionModelo()
            {
                IdRol = DTO.IdRol,
                Usuario = DTO.Usuario
            };
        }
    }
}
