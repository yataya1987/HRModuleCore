using System.Threading.Tasks;
using Abp.Application.Services;
using HRCoreModule.Authorization.Accounts.Dto;

namespace HRCoreModule.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
