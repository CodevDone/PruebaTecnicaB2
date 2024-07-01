using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;
using BluperDinner.Domain.User.ValueObjects;

namespace BluperDinner.Domain.Entities
{
    public sealed class User : AggregateRoot<UserId>
    {

        private User(
            UserId userId,
            string firstName,
            string lastName,
            string email,
            string pasword)
        :base(userId)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Pasword = pasword;
        }

        public string FirstName {get;set;} = null!;
        public string LastName {get;set;} = null!;
        public string Email {get;set;} = null!;
        public string Pasword {get;set;} = null!;
        
       
        public static User Create(
        string FirstName,
        string LastName,
        string Email,
        string Password)
        {
        return new(
            UserId.CreateUnique(),
            FirstName,
            LastName,
            Email,
            Password);
        }
        
        

        
    }
}