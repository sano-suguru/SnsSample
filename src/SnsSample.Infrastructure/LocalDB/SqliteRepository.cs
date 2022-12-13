using SnsSample.Domain.Interfaces;
using SqlKata.Execution;

namespace SnsSample.Infrastructure.LocalDB;

public class SqliteRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly QueryFactory db;

    public SqliteRepository(QueryFactory db)
    {
        this.db = db;
    }

    public async ValueTask<TEntity> InsertAsync(TEntity entity)
    {
        long id = await this.db.Query(typeof(TEntity).Name).InsertAsync(entity);

        return entity;
    }

    public ValueTask<TEntity?> SelectByIdAsnyc<TId>(TId id) where TId : notnull
    {
        throw new NotImplementedException();
    }

    public ValueTask<TEntity> UpdateAsync<TId>(TEntity entity, TId id) where TId : notnull
    {
        throw new NotImplementedException();
    }

    public ValueTask DeleteByIdAsync<TId>(TId id)
    {
        throw new NotImplementedException();
    }
}
