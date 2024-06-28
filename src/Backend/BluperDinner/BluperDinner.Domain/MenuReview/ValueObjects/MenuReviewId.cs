using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;

namespace BluperDinner.Domain.MenuReview.ValueObjects
{
    public sealed class MenuReviewId : ValueObject
    {
        public Guid Value{get;}
        private MenuReviewId (Guid value)
        {
            Value = value;
        }

        public static MenuReviewId  CreateUnique()
        {
            return new (Guid.NewGuid());
        }

        public override IEnumerable<object> GetEquialityComponents()
        {
            yield return Value;
        }
    }
}