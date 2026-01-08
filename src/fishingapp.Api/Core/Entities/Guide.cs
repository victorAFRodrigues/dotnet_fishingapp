using fishingapp.Api.Core.Enums;
using fishingapp.Api.Core.ValueObjects;

namespace fishingapp.Api.Core.Entities;

public class Guide
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public Rating Rating { get; private set; }
    public GuideType Type { get; private set; }
    public int Whatsapp { get; private set; }
    public int Phone { get; private set; }
    
    //relacionamentos
    public List<Guid> TagsId { get; private set; }
    public Guid AddressId { get; private set; }

    public Guide(string name, string description, Rating rating, GuideType type, int whatsapp, int phone, List<Guid> tagsId,  Guid addressId)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Rating = rating;
        Type = type;
        Whatsapp = whatsapp;
        Phone = phone;
        TagsId = tagsId;
        AddressId = addressId;
    }
}