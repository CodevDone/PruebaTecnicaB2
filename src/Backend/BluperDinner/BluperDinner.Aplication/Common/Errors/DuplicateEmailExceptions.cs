
using System.Net;

namespace BluperDinner.Aplication.Common.Errors
{
    public class DuplicateEmailExceptions : Exception, IServiceException
    {
        public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

        public string ErrorMessage => "Email already exist.";
    }
}