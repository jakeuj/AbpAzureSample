using Volo.Abp.Modularity;

namespace TestCiCd;

[DependsOn(
    typeof(TestCiCdDomainModule),
    typeof(TestCiCdTestBaseModule)
)]
public class TestCiCdDomainTestModule : AbpModule
{

}
