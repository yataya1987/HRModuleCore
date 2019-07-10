using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HRCoreModule.Roles.Dto;
using HRCoreModule.Users.Dto;

namespace HRCoreModule.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}