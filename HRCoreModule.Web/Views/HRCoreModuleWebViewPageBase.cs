using Abp.Web.Mvc.Views;

namespace HRCoreModule.Web.Views
{
    public abstract class HRCoreModuleWebViewPageBase : HRCoreModuleWebViewPageBase<dynamic>
    {

    }

    public abstract class HRCoreModuleWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected HRCoreModuleWebViewPageBase()
        {
            LocalizationSourceName = HRCoreModuleConsts.LocalizationSourceName;
        }
    }
}