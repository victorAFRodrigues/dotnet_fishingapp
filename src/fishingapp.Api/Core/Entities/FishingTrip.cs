using fishingapp.Api.Core.Enums;

namespace fishingapp.Api.Core.Entities;

public class FishingTrip
{
    public Guid Id { get; private set; }
    public Decimal TotalExpense { get; private set; }
    public DateTime Date { get; private set; }
    public TripStatus Status { get; private set; }
    
    //relacionamentos 
    public Guid FishingSpotId { get; private set; }
    public List<Guid> UsersId { get; private set; }
    public Guid GuideId { get; private set; }
    public FishingSpotType FishingSpotType { get; private set; }
    public List<Guid> TripExpensesId { get; private set; }
    
}