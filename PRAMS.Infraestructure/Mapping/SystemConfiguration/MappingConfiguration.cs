using AutoMapper;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using PRAMS.Domain.Models.SystemConfiguration;

namespace PRAMS.Infraestructure.Mapping.SystemConfiguration
{
    public class MappingConfiguration
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<AdmParametrosSeleccion, AdmParametrosNivel0Dto>()
                    .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.AdmParametroCategoria.Categoria))
                    .ForMember(dest => dest.Paremeter, opt => opt.MapFrom(src => src.Parametro))
                    .ForMember(dest => dest.CatDescription, opt => opt.MapFrom(src => src.Descripcion))
                    .ForMember(dest => dest.ParamDescription, opt => opt.MapFrom(src => src.AdmParametroCategoria.Descripcion))
                    .ForMember(dest => dest.TX_Filter, opt => opt.MapFrom(src => src.AdmParametroCategoria.TX_Filtro1_Nombre))
                    .ForMember(dest => dest.TX_FilterTwo, opt => opt.MapFrom(src => src.AdmParametroCategoria.TX_Filtro2_Nombre))
                    .ForMember(dest => dest.TX_FilterThree, opt => opt.MapFrom(src => src.AdmParametroCategoria.TX_Filtro3_Nombre))
                    .ForMember(dest => dest.TX_FilterFour, opt => opt.MapFrom(src => src.AdmParametroCategoria.TX_Filtro4_Nombre))
                    .ReverseMap();


                config.CreateMap<AdmParametrosSeleccion, AdmParametrosNivel1Dto>()
                    .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.AdmParametroCategoria.Categoria))
                    .ForMember(dest => dest.CatDescription, opt => opt.MapFrom(src => src.AdmParametroCategoria.Descripcion))
                    .ForMember(dest => dest.TX_Filter, opt => opt.MapFrom(src => src.TX_Filtro1))
                    .ForMember(dest => dest.TX_FilterTwo, opt => opt.MapFrom(src => src.TX_Filtro2))
                    .ReverseMap();

                config.CreateMap<AdmParametrosSeleccion, AdmParametrosNivel2Dto>()
                    .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.AdmParametroCategoria.Categoria))
                    .ForMember(dest => dest.CatDescription, opt => opt.MapFrom(src => src.AdmParametroCategoria.Descripcion))
                    .ForMember(dest => dest.TX_Filter, opt => opt.MapFrom(src => src.TX_Filtro3))
                    .ForMember(dest => dest.TX_FilterTwo, opt => opt.MapFrom(src => src.TX_Filtro4))
                    .ReverseMap();

                config.CreateMap<AdmParametrosSeleccion, AdmParametrosNivel3Dto>()
                    .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.AdmParametroCategoria.Categoria))
                    .ForMember(dest => dest.CatDescription, opt => opt.MapFrom(src => src.AdmParametroCategoria.Descripcion))
                    .ForMember(dest => dest.TX_Filter, opt => opt.MapFrom(src => src.TX_Filtro5))
                    .ForMember(dest => dest.TX_FilterTwo, opt => opt.MapFrom(src => src.TX_Filtro6))
                    .ReverseMap();


            });

            return mappingConfig;

        }

    }
}
