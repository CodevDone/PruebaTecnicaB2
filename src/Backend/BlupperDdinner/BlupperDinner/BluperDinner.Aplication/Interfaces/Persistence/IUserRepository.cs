using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Entities;

namespace BluperDinner.Aplication.Interfaces.Persistence
{
    public interface IUserRepository
    {
        void Add(User user);
        User? GetUserByEmail(string email);
    }
}