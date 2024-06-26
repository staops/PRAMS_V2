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
                    .ForMember(dest => dest.ParamterosID, opt => opt.MapFrom(src => src.ParamterosID))
                    .ForMember(dest => dest.Paremeter, opt => opt.MapFrom(src => src.Parametro))
                    .ForMember(dest => dest.TX_Filter, opt => opt.MapFrom(src => src.TX_Filtro1))
                    .ForMember(dest => dest.TX_FilterTwo, opt => opt.MapFrom(src => src.TX_Filtro2))
                    .ForMember(dest => dest.TX_FilterThree, opt => opt.MapFrom(src => src.TX_Filtro3))
                    .ForMember(dest => dest.TX_FilterFour, opt => opt.MapFrom(src => src.TX_Filtro4))
                    .ForMember(dest => dest.TX_FilterFive, opt => opt.MapFrom(src => src.TX_Filtro5))
                    .ForMember(dest => dest.CatDescription, opt => opt.MapFrom(src => src.AdmParametroCategoria.Descripcion))
                    .ForMember(dest => dest.ParamDescription, opt => opt.MapFrom(src => src.Descripcion))
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

                config.CreateMap<AdmMenuElements, AdmMenuRoleDto>()
                    .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                    .ForMember(dest => dest.Controlador, opt => opt.MapFrom(src => src.Controlador))
                    .ForMember(dest => dest.Accion, opt => opt.MapFrom(src => src.Accion))
                    .ForMember(dest => dest.Icono, opt => opt.MapFrom(src => src.Icono))
                    .ForMember(dest => dest.SubMenu, opt => opt.MapFrom(src => src.AdmMenuRoles));

                config.CreateMap<AdmMenuRole, AdmMenuRoleDosDto>()
                    .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.AdmMenuElement.Nombre))
                    .ForMember(dest => dest.Controlador, opt => opt.MapFrom(src => src.AdmMenuElement.Controlador))
                    .ForMember(dest => dest.Accion, opt => opt.MapFrom(src => src.AdmMenuElement.Accion))
                    .ForMember(dest => dest.Icono, opt => opt.MapFrom(src => src.AdmMenuElement.Icono));



            });

            return mappingConfig;

        }

    }
}
