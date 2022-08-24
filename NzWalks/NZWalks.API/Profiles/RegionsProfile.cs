using AutoMapper;

namespace NZWalks.API.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>();
            //.ReverseMap() will map back from  DTO Models to Domain models
        }
    }
}
