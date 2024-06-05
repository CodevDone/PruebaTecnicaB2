using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BluperDinner.Aplication.Interfaces.Services
{
    public interface IDateTimerProvider
    {
        DateTime UtcNow {get;}
    }
}