using Volo.Abp.Modularity;

namespace PasswordlessAuthentication;

public abstract class PasswordlessAuthenticationApplicationTestBase<TStartupModule> : PasswordlessAuthenticationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
