using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;

namespace BluperDinner.Domain.Common.ValueObjects
{
    public sealed class AverageRating : ValueObject
    {
        

        public AverageRating(double rating, int numRating)
        {
            Value = rating;
            NumRating = numRating;
        }

        public double Value { get; private set; }
        public int  NumRating { get; private set; }

        public static AverageRating Create(double rating = 0, int numRating =0)
        {
            return new AverageRating(rating, numRating); 
        }

        public void AddRating(double rating)
        {
            Value = (Value * NumRating + rating) / (NumRating + 1);
            NumRating += 1;
        }

        public void RemoveRating(double rating)
        {
            Value = (Value * NumRating - rating) / (NumRating - 1);
            NumRating -= 1;
        }

        public override IEnumerable<object> GetEquialityComponents()
        {
            throw new NotImplementedException();
        }
    }
}