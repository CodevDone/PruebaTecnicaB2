using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;
using BluperDinner.Domain.Menu.ValueObjects;

namespace BluperDinner.Domain.Menu.Entities
{
    public sealed class MenuItem :  Entity<MenuItemId>
    {

        public string Name {get;}
        public string Description {get;}

        public MenuItem(MenuItemId id,string name ,string description) 
        : base(id)
        {
            Name = name;
            Description = description;
        }

        public static MenuItem Create(string name, string description)
        {
            return new (MenuItemId.CreateUnique(), name, description);
        }
    }
     
}