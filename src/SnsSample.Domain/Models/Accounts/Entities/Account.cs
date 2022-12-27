using SnsSample.Domain.Models.Accounts.ValueObjects;

namespace SnsSample.Domain.Models.Accounts.Entities;

public class Account
{
    public AccountId? Id { get; private set; }
    public Nickname Nickname { get; private set; }
    public Code Code { get; private set; }
    public Salt Salt { get; private set; }
    public Hashed Hashed { get; private set; }

    public Account(
        Nickname nickname
        , Code code
        , Salt salt
        , Hashed hashed)
    {
        this.Nickname = nickname;
        this.Code = code;
        this.Salt = salt;
        this.Hashed = hashed;
    }
}
