using AutoMapper;
using PRAMS.Domain.Entities.Flujos.Dto;
using PRAMS.Domain.Entities.Forms.Dto;
using PRAMS.Domain.Entities.SystemConfiguration.Dto;
using PRAMS.Domain.Models.Flujos;
using PRAMS.Domain.Models.Forms;
using PRAMS.Domain.Models.SystemConfiguration;

namespace PRAMS.Infraestructure.Mapping.SystemConfiguration
{
    public class MappingConfiguration
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.AddProfile<ParametrosProfile>();
                config.AddProfile<MenuProfile>();
                config.AddProfile<ReportProfile>();
                config.AddProfile<AdmFlujosProfile>();
                config.AddProfile<AdmFlujosFormulariosProfile>();
                config.AddProfile<AdmFlujosFormulariosNotasProfile>();
                config.AddProfile<AdmFlujoPantallaUserProfile>();
                config.AddProfile<AdmFlujoFormularioEtapaAccionProfile>();
                config.AddProfile<AdmFormularioEtapaAccioneCampoProfile>();
                config.AddProfile<FlujosPantallasProfile>();
                config.AddProfile<FormFormularioFirmaProfile>();
                config.AddProfile<FormReferidoProfile>();
            });
            return mappingConfig;
        }
    }

    public class ParametrosProfile : Profile
    {
        public ParametrosProfile()
        {
            CreateMap<AdmParametrosSeleccion, AdmParametrosNivel0Dto>()
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

            CreateMap<AdmParametrosSeleccion, AdmParametrosNivel1Dto>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.AdmParametroCategoria.Categoria))
                .ForMember(dest => dest.CatDescription, opt => opt.MapFrom(src => src.AdmParametroCategoria.Descripcion))
                .ForMember(dest => dest.TX_Filter, opt => opt.MapFrom(src => src.TX_Filtro1))
                .ForMember(dest => dest.TX_FilterTwo, opt => opt.MapFrom(src => src.TX_Filtro2))
                .ReverseMap();

            CreateMap<AdmParametrosSeleccion, AdmParametrosNivel2Dto>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.AdmParametroCategoria.Categoria))
                .ForMember(dest => dest.CatDescription, opt => opt.MapFrom(src => src.AdmParametroCategoria.Descripcion))
                .ForMember(dest => dest.TX_Filter, opt => opt.MapFrom(src => src.TX_Filtro3))
                .ForMember(dest => dest.TX_FilterTwo, opt => opt.MapFrom(src => src.TX_Filtro4))
                .ReverseMap();

            CreateMap<AdmParametrosSeleccion, AdmParametrosNivel3Dto>()
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.AdmParametroCategoria.Categoria))
                .ForMember(dest => dest.CatDescription, opt => opt.MapFrom(src => src.AdmParametroCategoria.Descripcion))
                .ForMember(dest => dest.TX_Filter, opt => opt.MapFrom(src => src.TX_Filtro5))
                .ForMember(dest => dest.TX_FilterTwo, opt => opt.MapFrom(src => src.TX_Filtro6))
                .ReverseMap();
        }
    }

    public class MenuProfile : Profile
    {
        public MenuProfile()
        {
            CreateMap<AdmMenuElements, AdmMenuElementDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Controlador, opt => opt.MapFrom(src => src.Controlador))
                .ForMember(dest => dest.Accion, opt => opt.MapFrom(src => src.Accion))
                .ForMember(dest => dest.Icono, opt => opt.MapFrom(src => src.Icono))
                .ForMember(dest => dest.SubMenu, opt => opt.MapFrom(src => src.AdmMenuChildElements));

            CreateMap<AdmMenuElements, AdmSubMenuElementDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Controlador, opt => opt.MapFrom(src => src.Controlador))
                .ForMember(dest => dest.Accion, opt => opt.MapFrom(src => src.Accion))
                .ForMember(dest => dest.Icono, opt => opt.MapFrom(src => src.Icono))
                .ForMember(dest => dest.SubSubMenu, opt => opt.MapFrom(src => src.AdmMenuChildElements));

            CreateMap<AdmMenuElements, AdmSubSubMenuElementDto>()
                .ForMember(dest => dest.Nombre, opt => opt.MapFrom(src => src.Nombre))
                .ForMember(dest => dest.Controlador, opt => opt.MapFrom(src => src.Controlador))
                .ForMember(dest => dest.Accion, opt => opt.MapFrom(src => src.Accion))
                .ForMember(dest => dest.Icono, opt => opt.MapFrom(src => src.Icono));


            CreateMap<AdmMenuElements, AdmMenuInsertDto>().ReverseMap();
            CreateMap<AdmMenuElements, AdmMenuUpdateDto>().ReverseMap();

            CreateMap<AdmMenuRole, AdmMenuRoleDto>()
                .ForMember(dest => dest.MenuElementName, opt => opt.MapFrom(src => src.AdmMenuElement.Nombre));
            CreateMap<AdmMenuRoleDto, AdmMenuRole>();

            CreateMap<AdmMenuRole, AdmMenuRoleInsertDto>().ReverseMap();
            CreateMap<AdmMenuRole, AdmMenuRoleUpdateDto>().ReverseMap();
        }
    }

    public class ReportProfile : Profile
    {
        public ReportProfile()
        {
            CreateMap<AdmReports, AdmReportDto>().ReverseMap();
            CreateMap<AdmReports, AdmReportInsertDto>().ReverseMap();
            CreateMap<AdmReports, AdmReportUpdateDto>().ReverseMap();


            CreateMap<AdmReportsRole, AdmReportsRoleDto>()
                .ForMember(dest => dest.ReportName, opt => opt.MapFrom(src => src.AdmReports.ReportName))
                .ForMember(dest => dest.ReportType, opt => opt.MapFrom(src => src.AdmReports.ReportType))
                .ForMember(dest => dest.ReportLink, opt => opt.MapFrom(src => src.AdmReports.ReportLink))
                .ForMember(dest => dest.ReportDescription, opt => opt.MapFrom(src => src.AdmReports.ReportDescription))
                .ForMember(dest => dest.ReportParameters, opt => opt.MapFrom(src => src.AdmReports.ReportParameters))
                .ForMember(dest => dest.ReportRoleId, opt => opt.MapFrom(src => src.ReportRoleId))
                .ForMember(dest => dest.RoleId, opt => opt.MapFrom(src => src.RoleId))
                .ForMember(dest => dest.ReportId, opt => opt.MapFrom(src => src.ReportId));

            CreateMap<AdmReportsRole, AdmReportsRoleInsertDto>().ReverseMap();
            CreateMap<AdmReportsRole, AdmReportsRoleUpdateDto>().ReverseMap();
        }
    }

    public class AdmFlujosProfile : Profile
    {
        public AdmFlujosProfile()
        {
            CreateMap<AdmFlujoFormulario, AdmFlujoFormularioDto>().ReverseMap();
            CreateMap<AdmFlujoFormulario, AdmFlujoFormularioInsertDto>().ReverseMap();
            CreateMap<AdmFlujoFormulario, AdmFlujoFormularioUpdateDto>().ReverseMap();
        }
    }

    public class AdmFlujosFormulariosProfile : Profile
    {
        public AdmFlujosFormulariosProfile()
        {
            CreateMap<AdmFlujoFormularioEtapa, AdmFlujoFormularioEtapaDto>().ReverseMap();
            CreateMap<AdmFlujoFormularioEtapa, AdmFlujoFormularioEtapaInsertDto>().ReverseMap();
            CreateMap<AdmFlujoFormularioEtapa, AdmFlujoFormularioEtapaUpdateDto>().ReverseMap();
        }
    }

    public class AdmFlujosFormulariosNotasProfile : Profile
    {
        public AdmFlujosFormulariosNotasProfile()
        {
            CreateMap<AdmFlujoFormularioNota, AdmFlujoFormularioNotaDto>().ReverseMap();
            CreateMap<AdmFlujoFormularioNota, AdmFlujoFormularioNotaInsertDto>().ReverseMap();
            CreateMap<AdmFlujoFormularioNota, AdmFlujoFormularioNotaUpdateDto>().ReverseMap();
        }
    }

    public class AdmFlujoPantallaUserProfile : Profile
    {
        public AdmFlujoPantallaUserProfile()
        {
            CreateMap<AdmFlujoPantallaUser, AdmFlujoPantallaUserDto>().ReverseMap();
            CreateMap<AdmFlujoPantallaUser, AdmFlujoPantallaUserInsertDto>().ReverseMap();
            CreateMap<AdmFlujoPantallaUser, AdmFlujoPantallaUserUpdateDto>().ReverseMap();
        }
    }

    public class AdmFlujoFormularioEtapaAccionProfile : Profile
    {
        public AdmFlujoFormularioEtapaAccionProfile()
        {
            CreateMap<AdmFlujoFormularioEtapaAccion, AdmFlujoFormularioEtapaAccionDto>().ReverseMap();
            CreateMap<AdmFlujoFormularioEtapaAccion, AdmFlujoFormularioEtapaAccionInsertDto>().ReverseMap();
            CreateMap<AdmFlujoFormularioEtapaAccion, AdmFlujoFormularioEtapaAccionUpdateDto>().ReverseMap();
        }
    }

    public class AdmFormularioEtapaAccioneCampoProfile : Profile
    {
        public AdmFormularioEtapaAccioneCampoProfile()
        {
            CreateMap<AdmFormularioEtapaAccioneCampo, AdmFlujoFormularioEtapaAccionCampoDto>().ReverseMap();
            CreateMap<AdmFormularioEtapaAccioneCampo, AdmFlujoFormularioEtapaAccionCampoInsertDto>().ReverseMap();
            CreateMap<AdmFormularioEtapaAccioneCampo, AdmFlujoFormularioEtapaAccionCampoUpdateDto>().ReverseMap();
        }
    }

    public class FlujosPantallasProfile : Profile
    {
        public FlujosPantallasProfile()
        {
            CreateMap<FormFlujoPantalla, FormFlujoPantallaDto>().ReverseMap();
            CreateMap<FormFlujoPantalla, FormFlujoPantallaInsertDto>().ReverseMap();
            CreateMap<FormFlujoPantalla, FormFlujoPantallaUpdateDto>().ReverseMap();
        }
    }

    public class FormFormularioFirmaProfile : Profile
    {
        public FormFormularioFirmaProfile()
        {
            CreateMap<FormFormularioFirma, FormFormularioFirmaDto>().ReverseMap();
            CreateMap<FormFormularioFirma, FormFormularioFirmaInsertDto>().ReverseMap();
            CreateMap<FormFormularioFirma, FormFormularioFirmaUpdateDto>().ReverseMap();
        }
    }

    public class FormReferidoProfile : Profile
    {
        public FormReferidoProfile()
        {
            CreateMap<FormReferido, FormReferidoDto>().ReverseMap();
            CreateMap<FormReferido, FormReferidoInsertDto>().ReverseMap();
            CreateMap<FormReferido, FormReferidoUpdateDto>()
                .ForAllMembers(options => options.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<FormReferidoUpdateDto, FormReferido>()
                .ForAllMembers(options => options.Condition((src, dest, srcMember) => srcMember != null));

            CreateMap<FormReferidoUpdateDto, FormReferidoDto>().ReverseMap();
        }
    }
}
