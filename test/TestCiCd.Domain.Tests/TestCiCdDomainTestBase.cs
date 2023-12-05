using Volo.Abp.Modularity;

namespace TestCiCd;

/* Inherit from this class for your domain layer tests. */
public abstract class TestCiCdDomainTestBase<TStartupModule> : TestCiCdTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
