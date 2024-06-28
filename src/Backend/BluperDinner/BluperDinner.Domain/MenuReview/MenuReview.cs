

using BluperDinner.Domain.Common.Models;
using BluperDinner.Domain.MenuReview.ValueObjects;

namespace BluperDinner.Domain.MenuReview
{
    public sealed class MenuReview : AggregateRoot<MenuReviewId>
    {
        public MenuReview(MenuReviewId id) : base(id)
        {
        }
    }


}