using Volo.Abp.Modularity;

namespace JBH.WebUAT;

[DependsOn(
    typeof(WebUATApplicationModule),
    typeof(WebUATDomainTestModule)
    )]
public class WebUATApplicationTestModule : AbpModule
{

}
