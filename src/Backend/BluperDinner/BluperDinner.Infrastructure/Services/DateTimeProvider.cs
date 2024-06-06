using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Aplication.Interfaces.Services;

namespace BluperDinner.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimerProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}