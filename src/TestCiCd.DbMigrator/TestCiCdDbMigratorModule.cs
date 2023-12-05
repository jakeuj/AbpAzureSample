using TestCiCd.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TestCiCd.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TestCiCdEntityFrameworkCoreModule),
    typeof(TestCiCdApplicationContractsModule)
    )]
public class TestCiCdDbMigratorModule : AbpModule
{
}
