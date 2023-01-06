using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EatTogether.WebApi.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext exceptionContext)
    {
        var problemDetails = new ProblemDetails
        {
            Status = (int)HttpStatusCode.InternalServerError,
            Title = "An error occurred while processing your request. We apologize for the inconvenience.",
            Detail = exceptionContext.Exception.Message
        };
        exceptionContext.Result = new ObjectResult(problemDetails);
        exceptionContext.ExceptionHandled = true;
    }
}