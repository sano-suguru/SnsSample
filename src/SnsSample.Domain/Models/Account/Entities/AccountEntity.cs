using SnsSample.Domain.Models.Account.ValueObjects;

namespace SnsSample.Domain.Models.Account.Entities;

public class AccountEntity
{
    public AccountId AccountId { get; private set; }
    public Code Code { get; private set; }
    public Salt Salt { get; private set; }
    public Hashed Hashed { get; private set; }

    public AccountEntity(
        AccountId accountId
        , Code code
        , Salt salt
        , Hashed hashed)
    {
        this.AccountId = accountId;
        this.Code = code;
        this.Salt = salt;
        this.Hashed = hashed;
    }
}
