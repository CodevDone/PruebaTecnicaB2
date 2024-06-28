using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;

namespace BluperDinner.Domain.Host.ValueObjects
{
    public sealed class HostId : ValueObject
    {
        public Guid Value { get;   }

        private HostId(Guid value)  
        {
            Value = value;
        }

        public static HostId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEquialityComponents()
        {
            yield return Value;
        }
    }
}