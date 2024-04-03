using PasswordlessAuthentication.Samples;
using Xunit;

namespace PasswordlessAuthentication.EntityFrameworkCore.Domains;

[Collection(PasswordlessAuthenticationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PasswordlessAuthenticationEntityFrameworkCoreTestModule>
{

}
