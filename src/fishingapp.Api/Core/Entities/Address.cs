namespace fishingapp.Api.Core.Entities;

public class Address
{
    public Guid    Id          { get; private set; }
    public string  AddressLine { get; private set; }
    public string  City        { get; private set; }
    public string  State       { get; private set; }
    public string? ZipCode     { get; private set; }
    public string  Country     { get; private set; }
    
    private Address() { }
    
    public  Address(string addressLine, string city, string state, string country, string zipCode = "")
    {
        Id = Guid.NewGuid();
        AddressLine = addressLine;
        City = city;
        State = state;
        ZipCode = zipCode;
        Country = country;
    }
}