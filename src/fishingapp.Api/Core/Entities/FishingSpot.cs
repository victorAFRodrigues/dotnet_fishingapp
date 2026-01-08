using fishingapp.Api.Core.Enums;
using fishingapp.Api.Core.ValueObjects;

namespace fishingapp.Api.Core.Entities;

public class FishingSpot
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public Rating Rating { get; private set; }
    public FishingSpotType Type { get; private set; }
    public Guid AddressId { get; private set; }
    
    private FishingSpot(){}
    
    public FishingSpot(Guid id, string name, string description, Rating rating, FishingSpotType type, Guid addressId)
    {
        Id = id;
        Name = name;
        Description = description;
        Rating = rating;
        Type = type;
        AddressId = addressId;
    }
}