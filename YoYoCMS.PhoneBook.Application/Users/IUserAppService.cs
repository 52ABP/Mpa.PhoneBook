using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YoYoCMS.PhoneBook.Users.Dto;

namespace YoYoCMS.PhoneBook.Users
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task RemoveFromRole(long userId, string roleName);

        Task<ListResultOutput<UserListDto>> GetUsers();

        Task CreateUser(CreateUserInput input);
    }
}