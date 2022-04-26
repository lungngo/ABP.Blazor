using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace JBH.WebUAT.Blazor;

[Dependency(ReplaceServices = true)]
public class WebUATBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "WebUAT";
}
