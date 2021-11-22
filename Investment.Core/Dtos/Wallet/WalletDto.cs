using AutoMapper;
using Investment.Core.Interfaces;

namespace Investment.Core.Dtos.Wallet
{
    public class WalletDto:IMapping
    {
        public decimal Amount { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Entities.Wallet, WalletDto>()
                .ForMember(dto => dto.Amount, ent => ent.MapFrom(x => x.Amount));
        }
    }
}
