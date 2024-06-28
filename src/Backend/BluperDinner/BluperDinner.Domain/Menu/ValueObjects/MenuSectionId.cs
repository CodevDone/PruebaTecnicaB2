using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;

namespace BluperDinner.Domain.Menu.ValueObjects
{
    public sealed class MenuSectionId : ValueObject
    {
        public Guid Value{get;}
        private MenuSectionId(Guid value)
        {
            Value = value;
        }

        public static MenuSectionId CreateUnique()
        {
            return new (Guid.NewGuid());
        }

        public override IEnumerable<object> GetEquialityComponents()
        {
            yield return Value;
        }
    }
}