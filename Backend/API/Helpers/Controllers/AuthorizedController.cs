using API.Helpers.Program;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Helpers.Controllers;

[Authorize]
[Route(RouteGlobals.DefaultRoute)]
public abstract class AuthorizedController : ControllerBase
{
    
}