using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;

namespace BluperDinner.Domain.Dinner.ValueObjects
{
    public sealed class DinnerId : ValueObject
    {
        public Guid Value{get;}
        private DinnerId(Guid value)
        {
            Value = value;
        }

        public static DinnerId CreateUnique()
        {
            return new (Guid.NewGuid());
        }

        public override IEnumerable<object> GetEquialityComponents()
        {
            yield return Value;
        }
    }
}