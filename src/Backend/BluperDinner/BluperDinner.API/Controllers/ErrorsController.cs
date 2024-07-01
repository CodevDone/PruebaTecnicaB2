
using BluperDinner.Aplication.Common.Errors;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BluperDinner.API.Controllers
{
    public class ErrorsController : ControllerBase
    {
        [Route("/error/error")]
        [HttpGet]
        public IActionResult ErrorError()
        {
            // return View("Error!");
            Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

            var (statusCode, message) = exception switch
            {
                IServiceException serviceException => ((int)serviceException.StatusCode,serviceException.ErrorMessage),
                _ => (StatusCodes.Status500InternalServerError,"An unexpected error occurred."),
            };

            return Problem(statusCode: statusCode, title: message);
        }
    }
}