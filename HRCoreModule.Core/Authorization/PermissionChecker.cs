using Abp.Authorization;
using HRCoreModule.Authorization.Roles;
using HRCoreModule.Authorization.Users;

namespace HRCoreModule.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
