using SnsSample.Domain.Models.Account.ValueObjects;

namespace SnsSample.Domain.Models.Account.Entities;

public class AccountEntity
{
    public AccountId AccountId { get; init; }
    public Code Code { get; init; }
    public Nickname Nickname { get; init; }
    public Introduction Introduction { get; init; }
    public Location Location { get; init; }
    public WebSite WebSite { get; init; }
    public Birthday Birthday { get; init; }
    public Salt Salt { get; init; }
    public Hashed Hashed { get; init; }

    public AccountEntity(
        AccountId accountId,
        Code code,
        Nickname nickname,
        Introduction introduction,
        Location location,
        WebSite webSite,
        Birthday birthday,
        Salt salt,
        Hashed hashed)   
    {
        AccountId = accountId;
        Code = code;
        Nickname = nickname;
        Introduction = introduction;
        Location = location;
        WebSite = webSite;
        Birthday = birthday;
        Salt = salt;
        Hashed = hashed;
    }
}
