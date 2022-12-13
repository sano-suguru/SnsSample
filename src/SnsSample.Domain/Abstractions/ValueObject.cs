namespace SnsSample.Domain.Abstractions;

public abstract record ValueObject<TValue>(TValue Value) where TValue : notnull
{
    public override string ToString()
    {
        return this.Value.ToString() ?? throw new Exception("値オブジェクトの値がNULLです");
    }
}
