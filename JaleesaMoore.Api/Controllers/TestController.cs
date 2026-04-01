using Microsoft.AspNetCore.Mvc;

namespace JaleesaMoore.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "API is working!";
    }
}
