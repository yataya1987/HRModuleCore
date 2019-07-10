using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRCoreModule.MultiTenancy.Dto;

namespace HRCoreModule.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
