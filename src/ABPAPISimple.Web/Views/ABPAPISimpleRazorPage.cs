using Abp.AspNetCore.Mvc.Views;

namespace ABPAPISimple.Web.Views
{
    public abstract class ABPAPISimpleRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ABPAPISimpleRazorPage()
        {
            LocalizationSourceName = ABPAPISimpleConsts.LocalizationSourceName;
        }
    }
}
