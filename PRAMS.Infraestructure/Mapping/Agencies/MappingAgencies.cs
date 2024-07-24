using AutoMapper;
using PRAMS.Domain.Entities.Agencies.Dto;
using PRAMS.Domain.Models.Agencies;

namespace PRAMS.Infraestructure.Mapping.Agencies
{
    public class MappingAgencies
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.AddProfile<AgencieProfile>();
            });

            return mappingConfig;
        }
    }

    public class AgencieProfile : Profile
    {
        public AgencieProfile()
        {
            CreateMap<AgenciaDto, Agencia>().ReverseMap();
            CreateMap<AgenciaInsertDto, Agencia>().ReverseMap();
            CreateMap<AgenciaUpdateDto, Agencia>().ReverseMap();
        }
    }
}
