using Investment.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investment.Core.Interfaces
{
    public interface IUserRepository
    {
        Task CreateUser(User newUser);
    }
}
