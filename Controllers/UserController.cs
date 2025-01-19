using Microsoft.AspNetCore.Mvc;

namespace DemoLambdaApiGateway.Controllers;
[ApiController]
[Route("users")]
public class UserController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        var rand = new Random();
        return $"Usuário {rand.Next(0, 10)}";
    }

    [HttpGet("{id}")]
    public string GetById([FromRoute] int id)
    {
        return $"Usuário com id {id}";
    }
}
