using SnsSample.Domain.Abstractions;

namespace SnsSample.Domain.Interfaces;

public interface IRepository<TEntity, TKey, TKeyValue>
    where TEntity : notnull, EntityBase<TKey, TKeyValue>
        where TKey : notnull, ValueObject<TKeyValue>
            where TKeyValue : notnull
{
    ValueTask<TEntity?> SelectByIdAsnyc(TKey id);

    ValueTask InsertAsync(TEntity entity);

    ValueTask UpdateByIdAsync(TEntity entity, TKey id);

    ValueTask DeleteByIdAsync(TKey id);
}
