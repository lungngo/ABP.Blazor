using JBH.WebUAT.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace JBH.WebUAT.Permissions;

public class WebUATPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WebUATPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(WebUATPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WebUATResource>(name);
    }
}
