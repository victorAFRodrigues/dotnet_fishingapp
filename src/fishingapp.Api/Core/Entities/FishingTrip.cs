using fishingapp.Api.Core.Enums;

namespace fishingapp.Api.Core.Entities;

public class FishingTrip
{
    public Guid Id { get; private set; }
    public decimal TotalExpense { get; private set; }
    public DateTime Date { get; private set; }
    public TripStatus Status { get; private set; }
    
    //relacionamentos 
    public FishingSpot FishingSpot { get; private set; } //uma percaria deve apenas ter um local de pesca
    public Guide Guide { get; private set; } //uma pescaria pode ter apenas um guia/barqueiro
    public FishingSpotType FishingSpotType { get; private set; } //uma pescaria pode ser apenas de um tipo
    
    //uma pescaria pode ter muitas despesas
    private readonly List<TripExpense> _tripExpenses;
    public IReadOnlyCollection<TripExpense> TripExpenses => _tripExpenses;
    
    //uma pescaria pode ter varios pescadores envolvidos
    private readonly List<User> _users;
    public IReadOnlyCollection<User> Users => _users;
    
    private FishingTrip() { }

    public FishingTrip(TripStatus tripStatus, FishingSpot fishingSpot, List<User> users, Guide guide, FishingSpotType fishingSpotType, List<TripExpense> tripExpenses)
    {
        Id = Guid.NewGuid();
        Status = tripStatus;
        FishingSpot = fishingSpot;
        Guide = guide;
        FishingSpotType = fishingSpotType;
        _users = users ?? new();
        _tripExpenses = tripExpenses ?? new();
        Date = DateTime.UtcNow;
        
        CalculateTotalExpense();
    }

    private void CalculateTotalExpense()
    {   
        TotalExpense = _tripExpenses.Sum(e => e.Value);
    }
    
    public void AddExpense(TripExpense expense)
    {
        _tripExpenses.Add(expense);
        TotalExpense += expense.Value;
    }

    public void RemoveExpense(TripExpense expense)
    {
        if(_tripExpenses.Remove(expense)) TotalExpense -= expense.Value;
    }
    
    public void ChangeTripStatus(TripStatus tripStatus)
    {
        if (Status == TripStatus.Finished) throw new InvalidOperationException("Trip already finished."); 
        
        Status = tripStatus;
    }

}