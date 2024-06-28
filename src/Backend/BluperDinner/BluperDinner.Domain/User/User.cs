using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;
using BluperDinner.Domain.User.ValueObjects;

namespace BluperDinner.Domain.Entities
{
    public class User : AggregateRoot<UserId>
    {
        public User(UserId id) : base(id)
        {
        }

        public string FirstName {get;set;} = null!;
        public string LastName {get;set;} = null!;
        public string Email {get;set;} = null!;
        public string Pasword {get;set;} = null!;

        
    }
}