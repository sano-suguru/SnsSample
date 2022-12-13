using SnsSample.Domain.Models.Accounts.ValueObjects;

namespace SnsSample.Domain.Queries.Friendship;

public interface IFriendshipQueryService
{
    FriendshipReadModel Select(AccountId followeeAccountId, AccountId followerAccountId);
}
