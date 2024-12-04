using AutoMapper;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Models.People;

namespace PRAMS.Infraestructure.Mapping.People
{
    public class MappingPeople
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.AddProfile<PeopleProfile>();
            });

            return mappingConfig;
        }
    }

    public class PeopleProfile : Profile
    {
        public PeopleProfile()
        {
            CreateMap<Persona, PersonDto>().ReverseMap();
            CreateMap<Persona, PersonSmallDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.Nombre} {src.Inicial} {src.ApellidoPaterno} {src.ApellidoMaterno}"))
                .ReverseMap();
            CreateMap<Persona, PersonMergedDto>().ReverseMap();
            CreateMap<Persona, PersonUpdateDto>().ReverseMap();
            CreateMap<Persona, PersonInsertDto>().ReverseMap();


            CreateMap<PersonasDireccion, PersonasDireccionDto>().ReverseMap();
            CreateMap<PersonasDireccionInsertDto, PersonasDireccion>().ReverseMap();
            CreateMap<PersonasDireccionUpdateDto, PersonasDireccion>().ReverseMap();


            CreateMap<PersonasLink, PersonasLinkDto>().ReverseMap();
            CreateMap<PersonasLink, PersonasLinkPersonaDto>()
                .ReverseMap();
            CreateMap<PersonasLinkInsertDto, PersonasLink>().ReverseMap();
            CreateMap<PersonasLinkUpdateDto, PersonasLink>().ReverseMap();
        }
    }
}
