using SnsSample.Domain.Abstractions;
using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Friendships.ValueObjects;

namespace SnsSample.Domain.Models.Friendships.Entities;

public class Friendship : EntityBase<FriendshipId, long>
{
    public override FriendshipId? Id { get; set; }
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
