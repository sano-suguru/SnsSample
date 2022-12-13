using SnsSample.Domain.Models.Accounts.ValueObjects;

namespace SnsSample.Domain.Queries.AccountProfile;

public interface IAccoutProfileQueryService
{
    ValueTask<AccountProfileReadModel> SelectByCode(Code code);
}
