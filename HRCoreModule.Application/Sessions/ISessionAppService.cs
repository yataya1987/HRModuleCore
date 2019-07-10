using System.Threading.Tasks;
using Abp.Application.Services;
using HRCoreModule.Sessions.Dto;

namespace HRCoreModule.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
