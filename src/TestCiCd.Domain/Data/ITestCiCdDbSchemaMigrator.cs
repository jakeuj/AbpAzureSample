using System.Threading.Tasks;

namespace TestCiCd.Data;

public interface ITestCiCdDbSchemaMigrator
{
    Task MigrateAsync();
}
