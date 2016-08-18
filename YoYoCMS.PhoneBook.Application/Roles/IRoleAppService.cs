using System.Threading.Tasks;
using Abp.Application.Services;
using YoYoCMS.PhoneBook.Roles.Dto;

namespace YoYoCMS.PhoneBook.Roles
{
    /// <summary>
    ///     角色信息接口
    /// </summary>
    public interface IRoleAppService : IApplicationService
    {
        /// <summary>
        ///     修改角色的权限信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}