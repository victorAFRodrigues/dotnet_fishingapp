using fishingapp.Api.Core.Enums;

namespace fishingapp.Api.Core.ValueObjects;

public class Rating
{
    public double  Value { get; private set; }

    public Rating (double value)
    {
        if (value < 0.0 || value > 5.0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Rating must be between 0.0 and 5.0.");
        }
        
        Value = Math.Round(value, 2);
    }
}