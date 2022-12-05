using SnsSample.Domain.Models.Account.ValueObjects;

namespace SnsSample.Domain.Models.Account.Entities;

public class AccountEntity
{
    public AccountId AccountId { get; init; }
    public Code Code { get; init; }
    public Salt Salt { get; init; }
    public Hashed Hashed { get; init; }

    public AccountEntity(
        AccountId accountId,
        Code code,
        Salt salt,
        Hashed hashed)   
    {
        AccountId = accountId;
        Code = code;
        Salt = salt;
        Hashed = hashed;
    }
}
