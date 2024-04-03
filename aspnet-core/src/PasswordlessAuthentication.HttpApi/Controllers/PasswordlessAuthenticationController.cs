using PasswordlessAuthentication.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PasswordlessAuthentication.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PasswordlessAuthenticationController : AbpControllerBase
{
    protected PasswordlessAuthenticationController()
    {
        LocalizationResource = typeof(PasswordlessAuthenticationResource);
    }
}
