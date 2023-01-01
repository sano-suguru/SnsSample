using System;
using SnsSample.Domain.Models.Accounts.Entities;
using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Profiles.Entities;
using SnsSample.Domain.Queries.AccountProfile;
using SnsSample.Shared.DependencyInjection;
using SqlKata.Execution;

namespace SnsSample.Infrastructure.Sqlite;

[ScopedService]
public class AccountProfileQueryService : IAccountProfileQueryService
{
    private readonly QueryFactory db;

    public AccountProfileQueryService(QueryFactory db)
    {
        this.db = db;
    }

    public async ValueTask<AccountProfileReadModel?> SelectByCode(Code code)
    {
        var model = await this.db.Query(nameof(Account))
            .Join(nameof(Profile)
                , $"{nameof(Account)}.{nameof(Account.Id)}"
                , $"{nameof(Profile)}.{nameof(Profile.AccountId)}")
            .Where(nameof(Account.Code), code)
            .FirstAsync<AccountProfileReadModel>();

        return model;
    }
}
