using JBH.WebUAT.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace JBH.WebUAT.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class WebUATController : AbpControllerBase
{
    protected WebUATController()
    {
        LocalizationResource = typeof(WebUATResource);
    }
}
