using fishingapp.Api.Core.Enums;

namespace fishingapp.Api.Core.Entities;

public class TripExpense
{
    public Guid Id { get; private set; }
    public decimal Value { get; private set; }
    public ExpenseCategory Category { get; private set; }
    public DateTime Date { get; private set; }
    
    
}