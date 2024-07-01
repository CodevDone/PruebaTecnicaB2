using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BluperDinner.Contracts.Menus;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BluperDinner.API.Controllers
{
    [Route("hosts/{hostId}/menu")]
    public class MenuController : ApiController
    {
        [HttpPost]
        public IActionResult CreateMenu(CreateMenuRequest request,string hostId)
        {
            return Ok(request);
        }
    }
}