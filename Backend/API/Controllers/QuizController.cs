using API.Helpers.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class QuizController : AuthorizedController
{
    [HttpPost]
    public IActionResult Respond()
    {
        return Ok();
    }
}