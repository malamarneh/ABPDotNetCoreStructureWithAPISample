using Abp.Application.Services;

namespace ABPAPISimple
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ABPAPISimpleAppServiceBase : ApplicationService
    {
        protected ABPAPISimpleAppServiceBase()
        {
            LocalizationSourceName = ABPAPISimpleConsts.LocalizationSourceName;
        }
    }
}