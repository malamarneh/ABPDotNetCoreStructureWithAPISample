using Abp.AspNetCore.Mvc.Controllers;

namespace ABPAPISimple.Web.Controllers
{
    public abstract class ABPAPISimpleControllerBase: AbpController
    {
        protected ABPAPISimpleControllerBase()
        {
            LocalizationSourceName = ABPAPISimpleConsts.LocalizationSourceName;
        }
    }
}