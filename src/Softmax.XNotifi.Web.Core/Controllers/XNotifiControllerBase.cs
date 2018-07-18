using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Softmax.XNotifi.Controllers
{
    public abstract class XNotifiControllerBase: AbpController
    {
        protected XNotifiControllerBase()
        {
            LocalizationSourceName = XNotifiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
