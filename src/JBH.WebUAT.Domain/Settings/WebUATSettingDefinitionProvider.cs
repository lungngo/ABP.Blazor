using Volo.Abp.Settings;

namespace JBH.WebUAT.Settings;

public class WebUATSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WebUATSettings.MySetting1));
    }
}
