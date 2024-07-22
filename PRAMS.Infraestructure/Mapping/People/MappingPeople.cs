using AutoMapper;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Models.People;
using System.Reflection;

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
            CreateMap<Persona, PersonUpdateDto>().ReverseMap();


            CreateMap<PersonasDireccion, PersonasDireccionDto>().ReverseMap();
            CreateMap<PersonasDireccionInsertDto, PersonasDireccion>().ReverseMap();
            CreateMap<PersonasDireccionUpdateDto, PersonasDireccion>().ReverseMap();


            CreateMap<PersonasLink, PersonasLinkDto>().ReverseMap();
            CreateMap<PersonasLinkInsertDto, PersonasLink>().ReverseMap();
            CreateMap<PersonasLinkUpdateDto, PersonasLink>().ReverseMap();
        }
    }
}
