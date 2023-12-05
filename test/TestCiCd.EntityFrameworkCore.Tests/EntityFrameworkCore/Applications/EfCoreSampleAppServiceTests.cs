using TestCiCd.Samples;
using Xunit;

namespace TestCiCd.EntityFrameworkCore.Applications;

[Collection(TestCiCdTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TestCiCdEntityFrameworkCoreTestModule>
{

}
