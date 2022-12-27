using System.Data.SQLite;
using Dapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SnsSample.Domain.Abstractions;
using SnsSample.Domain.Interfaces;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace SnsSample.Infrastructure.Sqlite;

public static class ServiceCollectionExtensions
{
    public static void AddSqliteRepositories(this IServiceCollection services, IHostEnvironment env)
    {
        services.AddTransient((serviceProvider) =>
        {
            var SqliteDbPath = Path.Combine(env.ContentRootPath, "..", "SnsSample.Infrastructure", "Sqlite", "SnsSampleSQLite.db");
            SQLiteConnection dbConnection = new($"Data Source={SqliteDbPath}");
            SqliteCompiler sqliteCompiler = new();
            return new QueryFactory(dbConnection, sqliteCompiler);
        });

        services.AddScoped(typeof(IRepository<,,>), typeof(SqliteRepository<,,>));

        SqlMapper.AddTypeHandler(new ValueObjectTypeHandler<ValueObject<int>>());
        SqlMapper.AddTypeHandler(new ValueObjectTypeHandler<ValueObject<long>>());
        SqlMapper.AddTypeHandler(new ValueObjectTypeHandler<ValueObject<double>>());
        SqlMapper.AddTypeHandler(new ValueObjectTypeHandler<ValueObject<decimal>>());
        SqlMapper.AddTypeHandler(new ValueObjectTypeHandler<ValueObject<char>>());
        SqlMapper.AddTypeHandler(new ValueObjectTypeHandler<ValueObject<string>>());
        SqlMapper.AddTypeHandler(new ValueObjectTypeHandler<ValueObject<DateTime>>());
        SqlMapper.AddTypeHandler(new ValueObjectTypeHandler<ValueObject<bool>>());
    }
}
