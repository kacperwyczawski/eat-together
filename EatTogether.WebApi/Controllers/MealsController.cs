using Microsoft.AspNetCore.Mvc;

namespace EatTogether.WebApi.Controllers;

[Route("meals")]
public class MealsController : ApiController
{
    [HttpGet]
    public IActionResult GetMeals()
    {
        return Ok(new[] { "Pizza", "Spaghetti" });
    }
}