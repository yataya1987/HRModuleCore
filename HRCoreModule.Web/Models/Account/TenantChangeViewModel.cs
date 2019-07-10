using Abp.AutoMapper;
using HRCoreModule.Sessions.Dto;

namespace HRCoreModule.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}