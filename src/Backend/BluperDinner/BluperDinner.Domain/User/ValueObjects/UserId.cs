using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;

namespace BluperDinner.Domain.User.ValueObjects
{
    public class UserId : ValueObject
    {
        public Guid Value { get;   }

        private UserId (Guid value)  
        {
            Value = value;
        }

        public static UserId  CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEquialityComponents()
        {
            yield return Value;
        }
    }
}