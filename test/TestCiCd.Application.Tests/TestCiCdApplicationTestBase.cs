using Volo.Abp.Modularity;

namespace TestCiCd;

public abstract class TestCiCdApplicationTestBase<TStartupModule> : TestCiCdTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
