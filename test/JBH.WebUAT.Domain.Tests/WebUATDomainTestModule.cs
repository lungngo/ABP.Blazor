using JBH.WebUAT.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace JBH.WebUAT;

[DependsOn(
    typeof(WebUATEntityFrameworkCoreTestModule)
    )]
public class WebUATDomainTestModule : AbpModule
{

}
