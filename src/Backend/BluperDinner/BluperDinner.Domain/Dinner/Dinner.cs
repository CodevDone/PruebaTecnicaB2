using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Domain.Common.Models;
using BluperDinner.Domain.Dinner.ValueObjects;
using BluperDinner.Domain.Host.ValueObjects;
using BluperDinner.Domain.Menu.ValueObjects;

namespace BluperDinner.Domain.Dinner
{
    public class Dinner : AggregateRoot<DinnerId>
    {
         
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime? StartedDateTime { get; set; }
        public DateTime? EndedDateTime { get; set; }
        public string Status { get; set; } // Upcoming, InProgress, Ended, Cancelled
        public bool IsPublic { get; set; }
        public int MaxGuests { get; set; }
        public Price Price { get; set; }
        public HostId HostId { get; set; }
        public MenuId MenuId { get; set; }
        public string ImageUrl { get; set; }
        public Location Location { get; set; }
        public List<Reservation> Reservations { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime UpdatedDateTime { get; set; }
        public Dinner(DinnerId id) : base(id)
        {
        }
    }
}