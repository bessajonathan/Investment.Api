using AutoMapper;
using Investment.Core.Interfaces;

namespace Investment.Core.Dtos.User
{
    public class CreateUserDto : IMapping
    {
        public string Name { get; set; }
        public string UserName { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Entities.User, CreateUserDto>()
                .ForMember(dto => dto.Name, ent => ent.MapFrom(x => x.Name))
                .ForMember(dto => dto.UserName, ent => ent.MapFrom(x => x.UserName))
                .ReverseMap();
        }
    }
}
