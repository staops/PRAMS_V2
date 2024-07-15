using AutoMapper;
using PRAMS.Domain.Entities.People.Dto;
using PRAMS.Domain.Models.People;

namespace PRAMS.Infraestructure.Mapping.SystemConfiguration
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

        }
    }
}
