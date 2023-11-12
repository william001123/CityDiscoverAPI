using CityDiscoverDom.Modelos;
using CityDiscoverDTO.DTOs;

namespace CityDiscoverDTO.Mappers
{
    public static class clsFotoAnexadaMapper
    {
        public static clsFotoAnexadaModelo Map(this clsFotoAnexadaDTO model)
        {
            return new clsFotoAnexadaModelo()
            {
                IdFotoAnexada = model.IdFotoAnexada,
                IdUbicacion = model.IdUbicacion,
                bnImagen = model.bnImagen,
            };
        }

        public static List<clsFotoAnexadaModelo> Map(this List<clsFotoAnexadaDTO> model)
        {
            List<clsFotoAnexadaModelo> Dtos = new List<clsFotoAnexadaModelo>();

            foreach (clsFotoAnexadaDTO modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static List<clsFotoAnexadaDTO> Map(this List<clsFotoAnexadaModelo> model)
        {
            List<clsFotoAnexadaDTO> Dtos = new List<clsFotoAnexadaDTO>();

            foreach (clsFotoAnexadaModelo modelItem in model)
            {
                Dtos.Add(Map(modelItem));                
            }

            return Dtos;
        }

        public static clsFotoAnexadaDTO Map(this clsFotoAnexadaModelo DTO)
        {
            return new clsFotoAnexadaDTO()
            {
                IdFotoAnexada = DTO.IdFotoAnexada,
                IdUbicacion = DTO.IdUbicacion,
                bnImagen = DTO.bnImagen,
            };
        }
    }
}
