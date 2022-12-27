namespace SnsSample.Domain.Abstractions;

public abstract class EntityBase<TKey, TKeyValue>
    where TKey : ValueObject<TKeyValue>
        where TKeyValue : notnull
{
    public abstract TKey? Id { get; set; }
}
