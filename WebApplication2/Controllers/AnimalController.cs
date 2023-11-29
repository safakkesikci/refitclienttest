using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{

    [HttpPut(Name = "PutAnimal")]
    public Animal Put([FromForm]AnimalRequest animal)
    {
        return new Animal();
    }
}