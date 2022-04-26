using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace JBH.WebUAT.Data;

/* This is used if database provider does't define
 * IWebUATDbSchemaMigrator implementation.
 */
public class NullWebUATDbSchemaMigrator : IWebUATDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
