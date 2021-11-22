using AutoMapper;
using Investment.Core.Dtos.UserActive;
using Investment.Core.Dtos.Wallet;
using Investment.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace Investment.Core.Dtos.User
{
    public class UserDto:IMapping
    {
        public int Id { get; set; }
        public string FirebaseId { get; set; }
        public string Name { get; set; }
        public WalletDto Wallet { get; set; }
        public IEnumerable<UserActiveDto> Actives { get; set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; set; }
        public decimal SummarizedEquity { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Entities.User, UserDto>()
                .ForMember(dto => dto.Id, ent => ent.MapFrom(x => x.Id))
                .ForMember(dto => dto.Name, ent => ent.MapFrom(x => x.Name))
                .ForMember(dto => dto.FirebaseId, ent => ent.MapFrom(x => x.FirebaseId))
                .ForMember(dto => dto.Wallet, ent => ent.MapFrom(x => x.Wallet))
                .ForMember(dto => dto.SummarizedEquity, ent => ent.MapFrom(x => x.GetSummarizedEquity()))
                .ForMember(dto => dto.Actives, ent => ent.MapFrom(x => x.Actives))
                .ForMember(dto => dto.CreatedAt, ent => ent.MapFrom(x => x.CreatedAt))
                .ForMember(dto => dto.UpdatedAt, ent => ent.MapFrom(x => x.UpdatedAt));
        }
    }
}
