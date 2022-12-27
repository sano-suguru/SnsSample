using SnsSample.Domain.Interfaces;
using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Friendships.Entities;
using SnsSample.Domain.Models.Friendships.ValueObjects;
using SnsSample.Domain.Queries.AccountProfile;
using SnsSample.Domain.Queries.Friendship;
using SnsSample.Shared.DependencyInjection;

namespace SnsSample.App.Applications.Profiles;

[TransientService]
public class ProfilesApplicationService
{
    private readonly IAccountProfileQueryService accontProfileQueryService;
    private readonly IFriendshipQueryService friendshipQueryService;
    private readonly IRepository<Friendship, FriendshipId, long> friendshipRepository;

    public ProfilesApplicationService(
        IAccountProfileQueryService accontProfileQueryService
        , IFriendshipQueryService friendshipQueryService
        , IRepository<Friendship, FriendshipId, long> friendshipRepository
    )
    {
        this.accontProfileQueryService = accontProfileQueryService;
        this.friendshipQueryService = friendshipQueryService;
        this.friendshipRepository = friendshipRepository;
    }

    public async ValueTask<ProfileDto?> GetProfile(Code code)
    {

        if (await this.accontProfileQueryService.SelectByCode(code) is not AccountProfileReadModel profile)
        {
            return null;
        }

        return new ProfileDto(profile.Code, profile.Nickname, profile.Biography, profile.WebSite, profile.Birthday);
    }

    public async ValueTask Follow(Code followeeAccountCode, AccountId followerAccountId)
    {
        if (await this.accontProfileQueryService.SelectByCode(followeeAccountCode) is not { } accountProfile)
        {
            throw new FolloweeAccountNotFoundException();
        }

        AccountId followeeAccountId = accountProfile.AccountId;

        if (this.friendshipQueryService.Select(followeeAccountId, followerAccountId) is not null)
        {
            throw new FolloweeAlreadyFollowedException();
        }

        Friendship friendship = new(accountProfile.AccountId, followerAccountId);

        await this.friendshipRepository.InsertAsync(friendship);
    }

    public async ValueTask Unfollow(Code followeeAccountCode, AccountId followerAccountId)
    {
        if (await this.accontProfileQueryService.SelectByCode(followeeAccountCode) is not  AccountProfileReadModel accountProfile)
        {
            throw new FolloweeAccountNotFoundException();
        }

        AccountId followeeAccountId = accountProfile.AccountId;

        if (this.friendshipQueryService.Select(followeeAccountId, followerAccountId) is not FriendshipReadModel friendShip)
        {
            throw new NotFollowingFolloweeException();
        }

        await this.friendshipRepository.DeleteByIdAsync(friendShip.FriendshipId!);
    }
}
