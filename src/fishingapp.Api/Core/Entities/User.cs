namespace fishingapp.Api.Core.Entities;

public class User
{
    public Guid    Id        { get; private set; }
    public string  FirstName { get; private set; }
    public string  LastName  { get; private set; }
    public string  Email     { get; private set; }
    public string  Password  { get; private set; }
    public Guid    AddressId { get; private set; }

    public List<Guid> FishingPartnerIds { get; private set; } // algo como amizades em redes sociais 
    private User() { }

    public User(string firstName, string lastName, string email, string password, Guid addressId)
    {   
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        AddressId = addressId;
        FishingPartnerIds = new List<Guid>();
    }
}
