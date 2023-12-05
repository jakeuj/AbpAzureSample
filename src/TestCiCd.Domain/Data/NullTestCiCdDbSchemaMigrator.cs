using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TestCiCd.Data;

/* This is used if database provider does't define
 * ITestCiCdDbSchemaMigrator implementation.
 */
public class NullTestCiCdDbSchemaMigrator : ITestCiCdDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
