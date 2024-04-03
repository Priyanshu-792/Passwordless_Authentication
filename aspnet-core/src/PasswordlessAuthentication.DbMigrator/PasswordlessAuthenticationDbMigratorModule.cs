using PasswordlessAuthentication.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PasswordlessAuthentication.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PasswordlessAuthenticationEntityFrameworkCoreModule),
    typeof(PasswordlessAuthenticationApplicationContractsModule)
    )]
public class PasswordlessAuthenticationDbMigratorModule : AbpModule
{
}
