using SnsSample.Domain.Models.Accounts.ValueObjects;
using SnsSample.Domain.Models.Profiles.ValueObjects;

namespace SnsSample.App.Applications.Profiles;

public record ProfileDto(
    Code Code
    , Nickname Nickname
    , Biography? Biography
    , WebSite? WebSite
    , Birthday? Birthday
);
