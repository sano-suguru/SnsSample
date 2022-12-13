using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Friendships.ValueObjects;

namespace SnsSample.Domain.Models.Friendships.Entities;

public class Friendship
{
    public FriendshipId FriendshipId { get; private set; }
    public AccountId FolloweeId { get; private set; }
    public AccountId FollowerId { get; private set; }

    public Friendship(
        AccountId followeeId
        , AccountId followerId)
    {
        this.FolloweeId = followeeId;
        this.FollowerId = followerId;
    }
}
