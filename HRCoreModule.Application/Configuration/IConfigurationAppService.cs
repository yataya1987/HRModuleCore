using System.Threading.Tasks;
using Abp.Application.Services;
using HRCoreModule.Configuration.Dto;

namespace HRCoreModule.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}