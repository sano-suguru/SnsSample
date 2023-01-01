using System;
using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Queries.Friendship;
using SnsSample.Shared.DependencyInjection;

namespace SnsSample.Infrastructure.Sqlite;

[ScopedService]
public class FriendshipQueryService : IFriendshipQueryService
{
    public FriendshipReadModel Select(AccountId followeeAccountId, AccountId followerAccountId)
    {
        throw new NotImplementedException();
    }
}
