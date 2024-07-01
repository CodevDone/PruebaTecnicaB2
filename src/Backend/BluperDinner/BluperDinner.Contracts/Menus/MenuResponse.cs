using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BluperDinner.Contracts.Menus
{
    public record MenuResponse(
         string Id,
        string Name,
        string Description,
        float? AverageRating,
        string HostId,
        ReadOnlyCollection<string> DinnerIds,
        ReadOnlyCollection<string> MenuReviewIds,
        ReadOnlyCollection<MenuSectionResponse> Sections,
        DateTime CreatedDateTimeUtc,
        DateTime UpdatedDateTimeUtc);

    
}