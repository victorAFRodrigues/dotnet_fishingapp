namespace fishingapp.Api.Core.Entities;

public class Tag
{
    public Guid Id { get; private set; }
    public string Description { get; private set; }

    private Tag(){}

    public Tag(string description)
    {
        Id = Guid.NewGuid();
        Description = description;
    }
}