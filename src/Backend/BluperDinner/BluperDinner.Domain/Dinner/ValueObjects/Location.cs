using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;

namespace BluperDinner.Domain.Dinner.ValueObjects
{
    public class Location : ValueObject
    {
        public string Name { get; }
        public string Address { get; }
        public decimal Latitude { get; }
        public decimal Longitude { get; }

        public override IEnumerable<object> GetEquialityComponents()
        {
            yield return Address;
        }
    }
}