using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HRCoreModule.Configuration.Dto;

namespace HRCoreModule.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HRCoreModuleAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
