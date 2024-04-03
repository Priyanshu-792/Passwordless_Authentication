using Volo.Abp.Modularity;

namespace PasswordlessAuthentication;

[DependsOn(
    typeof(PasswordlessAuthenticationDomainModule),
    typeof(PasswordlessAuthenticationTestBaseModule)
)]
public class PasswordlessAuthenticationDomainTestModule : AbpModule
{

}
