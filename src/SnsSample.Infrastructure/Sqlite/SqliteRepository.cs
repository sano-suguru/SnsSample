using SnsSample.Domain.Abstractions;
using SnsSample.Domain.Interfaces;
using SqlKata.Execution;

namespace SnsSample.Infrastructure.Sqlite;

public class SqliteRepository<TEntity, TKey, TKeyValue>
    : IRepository<TEntity, TKey, TKeyValue>
        where TEntity : notnull, EntityBase<TKey, TKeyValue>
            where TKey : notnull, ValueObject<TKeyValue>
                where TKeyValue : notnull
{
    private readonly QueryFactory db;

    public SqliteRepository(QueryFactory db)
    {
        this.db = db;
    }

    public async ValueTask InsertAsync(TEntity entity)
    {
        TKeyValue id = await this.db.Query(typeof(TEntity).Name).InsertGetIdAsync<TKeyValue>(entity);

        entity.Id = (TKey)new ValueObject<TKeyValue>(id);
    }

    public async ValueTask<TEntity?> SelectByIdAsnyc(TKey id)
    {
        return await this.db.Query(typeof(TEntity).Name)
            .Where(nameof(EntityBase<TKey, TKeyValue>.Id), id.Value)
            .FirstAsync<TEntity?>();
    }

    public async ValueTask UpdateByIdAsync(TEntity entity, TKey id)
    {
        await this.db.Query(typeof(TEntity).Name)
           .Where(nameof(EntityBase<TKey, TKeyValue>.Id), id.Value)
           .UpdateAsync(entity);
    }

    public async ValueTask DeleteByIdAsync(TKey id)
    {
        await this.db.Query(typeof(TEntity).Name)
           .Where(nameof(EntityBase<TKey, TKeyValue>.Id), id.Value)
           .DeleteAsync();
    }
}
