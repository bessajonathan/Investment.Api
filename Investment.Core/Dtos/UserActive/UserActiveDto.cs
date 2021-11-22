using AutoMapper;
using Investment.Core.Dtos.Active;
using Investment.Core.Interfaces;

namespace Investment.Core.Dtos.UserActive
{
    public class UserActiveDto:IMapping
    {
        public ActiveDto Active { get; set; }
        public int Quantity { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Entities.UserActive, UserActiveDto>()
                .ForMember(dto => dto.Active, ent => ent.MapFrom(x => x.Active))
                .ForMember(dto => dto.Quantity, ent => ent.MapFrom(x => x.Quantity));
        }
    }
}
