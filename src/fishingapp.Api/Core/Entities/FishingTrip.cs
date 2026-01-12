using fishingapp.Api.Core.Enums;

namespace fishingapp.Api.Core.Entities;

public class FishingTrip
{
    public Guid Id { get; private set; }
    public decimal TotalExpense { get; private set; }
    public DateTime Date { get; private set; }
    public TripStatus Status { get; private set; }
    
    //relacionamentos 
    // public Guid FishingSpotId { get; private set; }
    // public List<Guid> UsersId { get; private set; }
    // public Guid GuideId { get; private set; }
    // public List<Guid> TripExpensesId { get; private set; }
    public FishingSpot FishingSpot { get; private set; } //uma percaria deve apenas ter um local de pesca
    public List<User> Users { get; private set; } //uma pescaria pode ter varios pescadores envolvidos
    public Guide Guide { get; private set; } //uma pescaria pode ter apenas um guia/barqueiro
    public FishingSpotType FishingSpotType { get; private set; } //uma pescaria pode ser apenas de um tipo
    public List<TripExpense> TripExpenses { get; private set; } //uma pescaria pode ter muitas despesas
    private FishingTrip() { }

    public FishingTrip(TripStatus tripStatus, FishingSpot fishingSpot, List<User> users, Guide guide, FishingSpotType fishingSpotType, List<TripExpense> tripExpenses)
    {
        Id = Guid.NewGuid();
        Status = tripStatus;
        FishingSpot = fishingSpot;
        Users = users;
        Guide = guide;
        FishingSpotType = fishingSpotType;
        TripExpenses = tripExpenses;
        TotalExpense = CalculateTotalExpense(TripExpenses);
        Date = DateTime.Now;
    }

    private decimal CalculateTotalExpense(List<TripExpense> tripExpenses)
    {   
        decimal totalExpense = 0;
        
        foreach(TripExpense expense in tripExpenses)
        {
            totalExpense += expense.Value;
        }
        
        return totalExpense;
    }
}