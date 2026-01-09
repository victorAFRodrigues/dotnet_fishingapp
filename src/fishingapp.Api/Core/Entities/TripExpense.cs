using fishingapp.Api.Core.Enums;

namespace fishingapp.Api.Core.Entities;

public class TripExpense
{
    public Guid Id { get; private set; }
    public decimal Value { get; private set; }
    public ExpenseCategory Category { get; private set; }
    public DateTime Date { get; private set; }
    
    private TripExpense() {}
    
    public TripExpense(decimal value, ExpenseCategory category)
    {
        Id = Guid.NewGuid();
        Value = value;
        Category = category;
        Date = DateTime.Now;
    }
    
}