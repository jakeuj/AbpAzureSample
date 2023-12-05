using TestCiCd.Samples;
using Xunit;

namespace TestCiCd.EntityFrameworkCore.Domains;

[Collection(TestCiCdTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TestCiCdEntityFrameworkCoreTestModule>
{

}
