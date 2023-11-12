using CityDiscoverSQL.Entidades;
using CityDiscoverDom.Modelos;

namespace CityDiscoverSQL.Mappers
{
    public static class RolMapper
    {
        public static RolEntidad Map(this clsRolModelo model)
        {
            return new RolEntidad()
            {
                IdRol = model.IdRol,
                strNombre = model.strNombre
            };
        }

        public static List<RolEntidad> Map(this List<clsRolModelo> model)
        {
            List<RolEntidad> Dtos = new List<RolEntidad>();

            foreach (clsRolModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsRolModelo> Map(this List<RolEntidad> model)
        {
            List<clsRolModelo> Dtos = new List<clsRolModelo>();

            foreach (RolEntidad modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsRolModelo Map(this RolEntidad DTO)
        {
            return new clsRolModelo()
            {
                IdRol = DTO.IdRol,
                strNombre = DTO.strNombre
            };
        }
    }
}
