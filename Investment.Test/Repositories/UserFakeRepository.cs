using Investment.Core.Entities;
using Investment.Core.Enums;
using Investment.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Investment.Test.Repositories
{
    public class UserFakeRepository : IUserRepository
    {
        public Task CreateUser(User newUser)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByFirebaseId(string firebaseId)
        {
            return new User
            {
                Name ="Test",
                CreatedAt = DateTime.Now,
                Id=1,
                FirebaseId = "1",
                Wallet = new Wallet
                {
                    Id =  1,
                    UserId = 1,
                    Amount = 10,
                },
                Actives= new UserActive[]
                {
                    new UserActive
                    {
                        UserId = 1,
                        Id=1,
                        ActiveId = 1,
                        Quantity = 2,
                        Active = new Active(15,EUserActiveType.PETR4)

                    },
                    new UserActive
                    {
                        UserId = 1,
                        Id =2,
                        ActiveId = 1,
                        Quantity = 1,
                        Active = new Active(15,EUserActiveType.MGLU3)
                    },
                }
            };
        }

        public async Task<bool> VerifyIfUserExistByFirebaseId(string firebaseId)
        {
            return true;
        }
    }
}
