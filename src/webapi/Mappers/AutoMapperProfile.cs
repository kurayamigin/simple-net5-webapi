using AutoMapper;
using webapi.Dto;
using webapi.Modules;

namespace webapi.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Status, StatusDto>();
        }
    }
}