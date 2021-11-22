using AutoMapper;
using Investment.Core.Enums;
using Investment.Core.Interfaces;

namespace Investment.Core.Dtos.Active
{
    public class ActiveDto:IMapping
    {
        public decimal Amount { get; private set; }
        public EUserActiveType ActiveType { get;  set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Entities.Active, ActiveDto>()
                .ForMember(dto => dto.Amount, ent => ent.MapFrom(x => x.Amount))
                .ForMember(dto => dto.ActiveType, ent => ent.MapFrom(x => x.ActiveType));
        }
    }
}
