using AutoMapper;
using example.Dto;
using example.Models;

namespace example
{
    public class MappingProfile :Profile
    {
        public MappingProfile() { 
        CreateMap<Actor, ActorDto>().ReverseMap();
        }
    }
}
