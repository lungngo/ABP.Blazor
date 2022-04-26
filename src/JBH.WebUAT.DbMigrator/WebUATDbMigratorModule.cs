using JBH.WebUAT.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace JBH.WebUAT.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WebUATEntityFrameworkCoreModule),
    typeof(WebUATApplicationContractsModule)
    )]
public class WebUATDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
