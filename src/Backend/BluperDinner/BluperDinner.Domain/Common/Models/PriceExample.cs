using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BluperDinner.Domain.Common.Models
{
    public class Price : ValueObject  
    {
     public decimal Amount { get; private set; }
     public string Currency { get; private set; }

     public Price(decimal amount,string currency)
     {
        Amount = amount;
        Currency = currency;
     }

        public override IEnumerable<object> GetEquialityComponents()
        {
            yield return Amount;
            yield return Currency;
        }
    }
}