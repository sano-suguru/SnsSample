using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Profiles.ValueObjects;

namespace SnsSample.Domain.Models.Profiles.Entities;

public class Profile
{
    public ProfileId ProfileId { get; private set; }
    public AccountId AccountId { get; private set; }
    public Nickname Nickname { get; private set; }
    public Biography Introduction { get; private set; }
    public Location Location { get; private set; }
    public WebSite WebSite { get; private set; }
    public Birthday Birthday { get; private set; }

    public Profile(
        ProfileId profileId
        , AccountId accountId
        , Nickname nickname
        , Biography introduction
        , Location location
        , WebSite webSite
        , Birthday birthday)
    {
        this.ProfileId = profileId;
        this.AccountId = accountId;
        this.Nickname = nickname;
        this.Introduction = introduction;
        this.Location = location;
        this.WebSite = webSite;
        this.Birthday = birthday;
    }
}
