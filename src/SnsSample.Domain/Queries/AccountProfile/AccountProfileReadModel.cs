using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Profiles.ValueObjects;

namespace SnsSample.Domain.Queries.AccountProfile;

public record AccountProfileReadModel(
    AccountId AccountId
    , Code Code
    , Nickname Nickname
    , Biography? Biography = null
    , WebSite? WebSite = null
    , Birthday? Birthday = null);