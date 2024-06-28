using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;

namespace BluperDinner.Domain.Menu.ValueObjects
{
    public sealed class MenuId : ValueObject
    {
        public Guid Value{get;}
        private MenuId(Guid value)
        {
            Value = value;
        }

        public static MenuId CreateUnique()
        {
            return new MenuId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEquialityComponents()
        {
            yield return Value;
        }
    }
}