using System.Data.SQLite;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SnsSample.Domain.Interfaces;
using SqlKata.Compilers;
using SqlKata.Execution;

namespace SnsSample.Infrastructure.LocalDB;

public static class ServiceCollectionExtensions
{
    public static void AddSqliteRepositories(this IServiceCollection services, IHostEnvironment env)
    {
        services.AddTransient((serviceProvider) =>
        {
            var SqliteDbPath = Path.Combine(env.ContentRootPath, "..", "SnsSample.Infrastructure", "LocalDB", "SnsSampleSQLite.db");
            SQLiteConnection dbConnection = new($"Data Source={SqliteDbPath}");
            SqliteCompiler sqliteCompiler = new();
            return new QueryFactory(dbConnection, sqliteCompiler);
        });

        services.AddScoped(typeof(IRepository<>), typeof(SqliteRepository<>));
    }
}