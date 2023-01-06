using System.Net;
using System.Text.Json;

namespace EatTogether.WebApi.Middlewares;

public class ErrorHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch
        {
            await HandleExceptionAsync(context);
        }
    }

    private static Task HandleExceptionAsync(HttpContext context)
    {
        const HttpStatusCode code = HttpStatusCode.InternalServerError;
        var error = new
            { error = "An error occurred while processing your request. We apologize for the inconvenience." };
        var result = JsonSerializer.Serialize(error);
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;
        return context.Response.WriteAsync(result);
    }
}