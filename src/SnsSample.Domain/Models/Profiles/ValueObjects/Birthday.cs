using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Models.Profiles.ValueObjects;

public record Birthday : ValueObject<DateTime>
{
    public Birthday(DateTime value) : base(value)
    {
    }

    public string ToString(string format)
    {
        return this.Value.ToString(format);
    }
}
