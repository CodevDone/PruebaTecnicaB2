using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace BluperDinner.Contracts.Menus
{
    public record MenuSectionResponse(
    string Id,
    string Name,
    string Description,
    ReadOnlyCollection<MenuItemResponse> Items);
    
    
        
    
}