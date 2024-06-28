using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;
using BluperDinner.Domain.Dinner.ValueObjects;
using BluperDinner.Domain.Host.ValueObjects;
using BluperDinner.Domain.Menu.ValueObjects;
using BluperDinner.Domain.User.ValueObjects;

namespace BluperDinner.Domain.Host
{
    public sealed class Host : Entity<HostId>
    {
        public string FirstName { get;  }
        public string LastName { get;  }
        public string ProfileImage { get;  }
        public double AverageRating { get;  }
        public UserId UserId { get;  }
        public List<MenuId> MenuIds { get;  }
        public List<DinnerId> DinnerIds { get;  }
        public DateTime CreatedDateTime { get;  }
        public DateTime UpdatedDateTime { get;  }

        public Host(HostId id,string firstName, string lastName)
        : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
    }
}