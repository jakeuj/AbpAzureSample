using Volo.Abp.Modularity;

namespace TestCiCd;

[DependsOn(
    typeof(TestCiCdApplicationModule),
    typeof(TestCiCdDomainTestModule)
)]
public class TestCiCdApplicationTestModule : AbpModule
{

}
