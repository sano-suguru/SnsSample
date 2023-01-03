using SnsSample.Domain.Abstractions;
using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Profiles.ValueObjects;

namespace SnsSample.Domain.Models.Profiles.Entities;

public class Profile : EntityBase<ProfileId, long>
{
    public override ProfileId? Id { get; set; }
    public AccountId AccountId { get; private set; }
    public Nickname Nickname { get; private set; }
    public Biography Biography { get; private set; }
    public Location Location { get; private set; }
    public WebSite WebSite { get; private set; }
    public Birthday Birthday { get; private set; }

    public Profile(
        AccountId accountId
        , Nickname nickname
        , Biography biography
        , Location location
        , WebSite webSite
        , Birthday birthday)
    {
        this.AccountId = accountId;
        this.Nickname = nickname;
        this.Biography = biography;
        this.Location = location;
        this.WebSite = webSite;
        this.Birthday = birthday;
    }
}
