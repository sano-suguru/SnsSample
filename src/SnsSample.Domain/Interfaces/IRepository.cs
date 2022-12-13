namespace SnsSample.Domain.Interfaces;

public interface IRepository<TEntity> where TEntity : class
{
    ValueTask<TEntity?> SelectByIdAsnyc<TId>(TId id) where TId : notnull;

    ValueTask<TEntity> InsertAsync(TEntity entity);

    ValueTask<TEntity> UpdateAsync<TId>(TEntity entity, TId id) where TId : notnull;

    ValueTask DeleteByIdAsync<TId>(TId id);
}
