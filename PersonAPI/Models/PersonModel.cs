namespace PersonAPI.Models;

public class PersonModel
{
    public Guid Id { get; private set; }
    public string Name { get; set; } = string.Empty;
}
