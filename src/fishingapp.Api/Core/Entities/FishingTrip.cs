using fishingapp.Api.Core.Enums;

namespace fishingapp.Api.Core.Entities;

public class FishingTrip
{
    public Guid Id { get; private set; }
    public decimal TotalExpense { get; private set; }
    public DateTime Date { get; private set; }
    public TripStatus Status { get; private set; }
    
    //relacionamentos 
    public Guid FishingSpotId { get; private set; }
    public List<Guid> UsersId { get; private set; }
    public Guid GuideId { get; private set; }
    public FishingSpotType FishingSpotType { get; private set; }
    public List<Guid> TripExpensesId { get; private set; }
    public List<TripExpense> TripExpenses { get; private set; }
    private FishingTrip() { }

    public FishingTrip(TripStatus tripStatus, Guid fishingSpotId, List<Guid> usersId, Guid guideId, FishingSpotType fishingSpotType, List<Guid> tripExpensesId)
    {
        Status = tripStatus;
        FishingSpotId = fishingSpotId;
        UsersId = usersId;
        GuideId = guideId;
        FishingSpotType = fishingSpotType;
        TripExpensesId = tripExpensesId;
        TotalExpense = CalculateTotalExpense(TripExpensesId);
        Date = DateTime.Now;
    }

    private decimal CalculateTotalExpense(List<Guid> tripExpensesId)
    {   
        decimal totalExpense = 0;
        
        foreach(Guid id in tripExpensesId)
        {
            totalExpense += TripExpense.Equal(id).Value;
        }
        
        return totalExpense;
    }
}