using AutoMapper;
using SocialMediaProject.Models.Dto;
using SocialMediaProject.Models.Entities;

namespace SocialMediaProject.Helpers
{
    public class AutoMapperConfigurations : Profile
    {
        public AutoMapperConfigurations()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
