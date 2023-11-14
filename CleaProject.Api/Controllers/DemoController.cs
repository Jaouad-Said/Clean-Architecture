using CleanProject.Api.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CleanProject.Api.Coltrollers;

[Route("[controller]")]
public class DemoController : ApiController
{
    [HttpGet]
    public IActionResult ListDemo()
    {
        return Ok(Array.Empty<string>());
    }
}