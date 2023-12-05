using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestCiCd.Data;
using Volo.Abp.DependencyInjection;

namespace TestCiCd.EntityFrameworkCore;

public class EntityFrameworkCoreTestCiCdDbSchemaMigrator
    : ITestCiCdDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTestCiCdDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the TestCiCdDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TestCiCdDbContext>()
            .Database
            .MigrateAsync();
    }
}
