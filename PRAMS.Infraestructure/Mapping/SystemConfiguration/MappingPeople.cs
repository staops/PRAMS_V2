using AutoMapper;

namespace PRAMS.Infraestructure.Mapping.SystemConfiguration
{
    public class MappingPeople
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
            });

            return mappingConfig;
        }
    }
}
