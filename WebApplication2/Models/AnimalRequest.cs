namespace WebApplication2;

public class AnimalRequest
{
    public string? Name { get; set; }
    public IFormFile AnimalFile { get; set; } = null!;
   
}