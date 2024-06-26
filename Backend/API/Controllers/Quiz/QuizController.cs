using API.Helpers.Controllers;
using BL.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Quiz;

public class QuizController(IQuizService quizService) : AuthorizedController
{
    [HttpPost]
    public IActionResult Respond()
    {
        return Ok();
    }
}