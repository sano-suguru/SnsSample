namespace SnsSample.Domain.Abstractions;

public record ValueObject<TValue>(TValue Value) where TValue : notnull
{
    public override string? ToString() => this.Value.ToString();
}
