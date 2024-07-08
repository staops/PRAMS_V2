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




                config.CreateMap<AdmMenuElements, AdmMenuElementDto>()
                    .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                    .ForMember(dest => dest.Controlador, opt => opt.MapFrom(src => src.Controlador))
                    .ForMember(dest => dest.Accion, opt => opt.MapFrom(src => src.Accion))
                    .ForMember(dest => dest.Icono, opt => opt.MapFrom(src => src.Icono))
                    .ForMember(dest => dest.SubMenu, opt => opt.MapFrom(src => src.AdmMenuChildElements));

                config.CreateMap<AdmMenuElements, AdmSubMenuElementDto>()
                    .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                    .ForMember(dest => dest.Controlador, opt => opt.MapFrom(src => src.Controlador))
                    .ForMember(dest => dest.Accion, opt => opt.MapFrom(src => src.Accion))
                    .ForMember(dest => dest.Icono, opt => opt.MapFrom(src => src.Icono))
                    .ForMember(dest => dest.SubSubMenu, opt => opt.MapFrom(src => src.AdmMenuChildElements));

                config.CreateMap<AdmMenuElements, AdmSubSubMenuElementDto>()
                    .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                    .ForMember(dest => dest.Controlador, opt => opt.MapFrom(src => src.Controlador))
                    .ForMember(dest => dest.Accion, opt => opt.MapFrom(src => src.Accion))
                    .ForMember(dest => dest.Icono, opt => opt.MapFrom(src => src.Icono));


                config.CreateMap<AdmMenuElements, AdmMenuInsertDto>().ReverseMap();
                config.CreateMap<AdmMenuElements, AdmMenuUpdateDto>().ReverseMap();

                config.CreateMap<AdmMenuRole, AdmMenuRoleDto>()
                    .ForMember(dest => dest.MenuElementName, opt => opt.MapFrom(src => src.AdmMenuElement.Nombre));
                config.CreateMap<AdmMenuRoleDto, AdmMenuRole>();

                config.CreateMap<AdmMenuRole, AdmMenuRoleInsertDto>().ReverseMap();
                config.CreateMap<AdmMenuRole, AdmMenuRoleUpdateDto>().ReverseMap();





                config.CreateMap<AdmReports, AdmReportDto>().ReverseMap();
                config.CreateMap<AdmReports, AdmReportInsertDto>().ReverseMap();
                config.CreateMap<AdmReports, AdmReportUpdateDto>().ReverseMap();


                config.CreateMap<AdmReportsRole, AdmReportsRoleDto>()
                .ForMember(dest => dest.ReportName, opt => opt.MapFrom(src => src.AdmReports.ReportName))
                .ForMember(dest => dest.ReportType, opt => opt.MapFrom(src => src.AdmReports.ReportType))
                .ForMember(dest => dest.ReportLink, opt => opt.MapFrom(src => src.AdmReports.ReportLink))
                .ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.AdmReports.ReportDescription))
                .ForMember(dest => dest.ReportParameters, opt => opt.MapFrom(src => src.AdmReports.ReportParameters))
                .ForMember(dest => dest.ReportRoleId, opt => opt.MapFrom(src => src.ReportRoleId))
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.RoleId))
                .ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.ReportId));

                config.CreateMap<AdmReportsRole, AdmReportsRoleInsertDto>().ReverseMap();
                config.CreateMap<AdmReportsRole, AdmReportsRoleUpdateDto>().ReverseMap();


                //.ForMember(dest => dest.ReportName, opt => opt.MapFrom(src => src.ReportName))
                //.ForMember(dest => dest.ReportType, opt => opt.MapFrom(src => src.ReportType))
                //.ForMember(dest => dest.ReportLink, opt => opt.MapFrom(src => src.ReportLink))
                //.ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.ReportDescription))
                //.ForMember(dest => dest.ReportParameters, opt => opt.MapFrom(src => src.ReportParameters));



            });

            return mappingConfig;

        }

    }
}
