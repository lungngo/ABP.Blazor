using System;
using System.Collections.Generic;
using System.Text;
using JBH.WebUAT.Localization;
using Volo.Abp.Application.Services;

namespace JBH.WebUAT;

/* Inherit your application services from this class.
 */
public abstract class WebUATAppService : ApplicationService
{
    protected WebUATAppService()
    {
        LocalizationResource = typeof(WebUATResource);
    }
}
