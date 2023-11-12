using CityDiscoverSQL.Entidades;
using CityDiscoverDom.Modelos;

namespace CityDiscoverSQL.Mappers
{
    public static class FotoAnexadaMapper
    {
        public static FotoAnexadaEntidad Map(this clsFotoAnexadaModelo model)
        {
            return new FotoAnexadaEntidad()
            {
                IdFotoAnexada = model.IdFotoAnexada,
                IdUbicacion = model.IdUbicacion,
                bnImagen = model.bnImagen,
            };
        }

        public static List<FotoAnexadaEntidad> Map(this List<clsFotoAnexadaModelo> model)
        {
            List<FotoAnexadaEntidad> Dtos = new List<FotoAnexadaEntidad>();

            foreach (clsFotoAnexadaModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsFotoAnexadaModelo> Map(this List<FotoAnexadaEntidad> model)
        {
            List<clsFotoAnexadaModelo> Dtos = new List<clsFotoAnexadaModelo>();

            foreach (FotoAnexadaEntidad modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsFotoAnexadaModelo Map(this FotoAnexadaEntidad DTO)
        {
            return new clsFotoAnexadaModelo()
            {
                IdFotoAnexada = DTO.IdFotoAnexada,
                IdUbicacion = DTO.IdUbicacion,
                bnImagen = DTO.bnImagen,
            };
        }
    }
}
