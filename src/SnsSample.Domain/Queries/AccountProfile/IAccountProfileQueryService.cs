using SnsSample.Domain.Models.Accounts.ValueObjects;

namespace SnsSample.Domain.Queries.AccountProfile;

public interface IAccountProfileQueryService
{
    ValueTask<AccountProfileReadModel?> SelectByCode(Code code);
}
