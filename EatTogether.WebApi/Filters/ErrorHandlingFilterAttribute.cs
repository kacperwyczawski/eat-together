using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EatTogether.WebApi.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext exceptionContext)
    {
        var error = new
            { error = "An error occurred while processing your request. We apologize for the inconvenience." };
        exceptionContext.Result = new ObjectResult(error)
            { StatusCode = 500 };
        exceptionContext.ExceptionHandled = true;
    }
}