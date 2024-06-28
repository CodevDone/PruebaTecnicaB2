
using BluperDinner.Domain.Common.Models;
using BluperDinner.Domain.Common.ValueObjects;
using BluperDinner.Domain.Dinner.ValueObjects;
using BluperDinner.Domain.Host.ValueObjects;
using BluperDinner.Domain.Menu.Entities;
using BluperDinner.Domain.Menu.ValueObjects;
using BluperDinner.Domain.MenuReview.ValueObjects;

namespace BluperDinner.Domain.Menu
{
    public sealed class Menu : AggregateRoot<MenuItemId>
    {
        private readonly List<MenuSection> _section = new();
        private readonly List<DinnerId> _dinners = new();
         private readonly List<MenuReviewId> _reviews = new();

        private Menu(MenuItemId menuId, string name, string description, HostId hostId, DateTime createDateTime, DateTime updateDateTime)
        : base(menuId)
        {
            Name = name;
            Description = description;
            HostId = hostId;
            CreateDateTime = createDateTime;
            UpdateDateTime = updateDateTime;
        }

        public string Name {get;}
        public string Description {get;}
        public AverageRating AverageRating{get;}

        public IReadOnlyList<MenuSection> Sections => _section.AsReadOnly();
        
        public HostId HostId {get;}

        public IReadOnlyList<DinnerId> DinnerIds => _dinners.AsReadOnly();

        public IReadOnlyList<MenuReviewId> MenuReviewIds => _reviews.AsReadOnly();

        public DateTime CreateDateTime {get;}
        public DateTime UpdateDateTime {get;}


        public static Menu Create(string name, string description, HostId hostId)
        {
            return new (MenuItemId.CreateUnique(), name, description, hostId, DateTime.UtcNow, DateTime.UtcNow);
        }

        
    }
}