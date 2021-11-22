using AutoMapper;
using Investment.Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Investment.Core.Dtos.User
{
    public class CreateUserDto : IMapping
    {
        [Required(ErrorMessage ="Informe o nome do usuário")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Informe o id do firebase")]
        public string FirebaseId { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Entities.User, CreateUserDto>()
                .ForMember(dto => dto.Name, ent => ent.MapFrom(x => x.Name))
                .ForMember(dto => dto.FirebaseId, ent => ent.MapFrom(x => x.FirebaseId))
                .ReverseMap();
        }
    }
}
