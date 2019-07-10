using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using HRCoreModule.Authorization.Users;
using HRCoreModule.MultiTenancy;
using HRCoreModule.Users;
using Microsoft.AspNet.Identity;

namespace HRCoreModule
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class HRCoreModuleAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected HRCoreModuleAppServiceBase()
        {
            LocalizationSourceName = HRCoreModuleConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}