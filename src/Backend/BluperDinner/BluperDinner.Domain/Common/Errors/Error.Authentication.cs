using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorOr;

namespace BluperDinner.Domain.Common
{
    public static partial class Errors
    {
        public static class Authentication
        {
            public static Error InvalidCredentials => Error.Validation(
            code: "User.InvalidCredentials",
            description: "Invalid credentials.");
        }

        
    }
}