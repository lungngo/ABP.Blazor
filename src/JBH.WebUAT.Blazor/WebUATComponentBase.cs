using JBH.WebUAT.Localization;
using Volo.Abp.AspNetCore.Components;

namespace JBH.WebUAT.Blazor;

public abstract class WebUATComponentBase : AbpComponentBase
{
    protected WebUATComponentBase()
    {
        LocalizationResource = typeof(WebUATResource);
    }
}
