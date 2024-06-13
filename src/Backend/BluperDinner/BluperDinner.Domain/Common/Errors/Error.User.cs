using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorOr;

namespace BluperDinner.Domain.Common
{
    public static partial class Errors
    {
        
        public static class User 
        {
            public static Error DuplicateEmail => Error.Conflict(
                code: "User.DuplicateEmail",
                description: "Email Already Exists"
            );
        }

    }
}