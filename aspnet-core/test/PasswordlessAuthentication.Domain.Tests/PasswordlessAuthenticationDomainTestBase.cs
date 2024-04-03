using Volo.Abp.Modularity;

namespace PasswordlessAuthentication;

/* Inherit from this class for your domain layer tests. */
public abstract class PasswordlessAuthenticationDomainTestBase<TStartupModule> : PasswordlessAuthenticationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
