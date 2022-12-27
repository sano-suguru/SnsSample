using Microsoft.AspNetCore.Mvc;
using SnsSample.App.Applications.Profiles;
using SnsSample.Domain.Models.Accounts.ValueObjects;

namespace SnsSample.Mvc.Controllers;

[Route("profiles")]
public class ProfilesController : Controller
{
    private readonly ProfilesApplicationService profileApplicationService;

    public ProfilesController(ProfilesApplicationService profileApplicationService)
    {
        this.profileApplicationService = profileApplicationService;
    }

    [Route("{code}")]
    public async ValueTask<IActionResult> Details([FromRoute] string code)
    {
        Code? _code;
        try
        {
            _code = new Code(code);
        }
        catch (NullOrWhiteSpaceCodeException)
        {
            return this.NotFound();
        }
        catch (CodeLengthOutOfRangeException)
        {
            return this.NotFound();
        }
        catch (IllegalCodePatternException)
        {
            return this.NotFound();
        }
        catch
        {
            throw;
        }

        if (await this.profileApplicationService.GetProfile(_code) is not ProfileDto dto)
        {
            return this.NotFound();
        }

        return this.View(dto);
    }
}
