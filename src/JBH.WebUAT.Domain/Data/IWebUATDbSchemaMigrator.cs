using System.Threading.Tasks;

namespace JBH.WebUAT.Data;

public interface IWebUATDbSchemaMigrator
{
    Task MigrateAsync();
}
