using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NG.PhoneBook.Roles.Dto;

namespace NG.PhoneBook.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
