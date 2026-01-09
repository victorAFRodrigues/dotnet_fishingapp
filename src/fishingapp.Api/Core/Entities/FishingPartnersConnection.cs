namespace fishingapp.Api.Core.Entities;

public class FishingPartnersConnection
{
    public Guid ConnectionId { get; private set; }
    public Guid FishingPartner1Id { get; private set; }
    public Guid FishingPartner2Id { get; private set; }
    public DateTime DateCreated { get; private set; }
    
    private FishingPartnersConnection() { }

    public FishingPartnersConnection(Guid fishingPartner1Id, Guid fishingPartner2Id)
    {
        ConnectionId = Guid.NewGuid();
        FishingPartner1Id = fishingPartner1Id;
        FishingPartner2Id = fishingPartner2Id;
        DateCreated = DateTime.Now;
    }
}