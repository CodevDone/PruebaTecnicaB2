using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BluperDinner.API.Filters
{
    public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exeption = context.Exception;

            var problemDetail = new ProblemDetails
            {
                // Instance = context.HttpContext.Request.Path,
                // Status = 500,
                // Detail = exeption.Message
                Type = "https://tools.ietf.org/html/rfc7231#section-6.6.1",
                Title = "An error ocurred while processing our request.",
                Status = (int)HttpStatusCode.InternalServerError,
            };


            context.Result = new ObjectResult(problemDetail);
            
            context.ExceptionHandled = true;
        }
    }
}